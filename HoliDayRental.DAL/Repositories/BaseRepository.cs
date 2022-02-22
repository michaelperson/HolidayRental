using HoliDayRental.DAL.Extensions;
using HoliDayRental.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Repositories
{
    public abstract class BaseRepository<T, TKey> : IRepository<T, TKey>
        where T : IEntity<TKey>, new()
        where TKey : struct
    {
        protected IDbTransaction _transaction;
        protected IDbConnection _connection { get { return _transaction.Connection; } }

        protected abstract string SelectCommand { get; }
        protected abstract string InsertCommand { get; }
        protected abstract string UpdateCommand { get; }
        protected abstract string DeleteCommand { get; }
        protected abstract string OneCommand { get; }
      


        public BaseRepository(IDbTransaction transaction)
        {
            _transaction = transaction;
        }




        public virtual T GetOne(TKey id)
        {
            return _connection.QuerySingleOrDefault<T>(OneCommand, new
            {
                Id = id
            }, _transaction);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return _connection.Query<T>(SelectCommand, null, _transaction);
        }
        public virtual bool Add(T Entity)
        {
            try
            {
                _connection.ExecuteScalar<TKey>(InsertCommand
                                                          , FieldToCollumn(Entity)
                                                          , _transaction);

                return true;
            }
            catch (Exception ex)
            {
                //TODO: Log ex
                Debug.WriteLine(ex.Message);
                return false;
            }
        }
        public virtual bool Update(T Entity)
        {
            try
            {
                _connection.Execute(UpdateCommand
                                                                   , FieldToCollumn(Entity)
                                                                   , _transaction);
                return true;
            }
            catch (Exception ex)
            {
                //TODO: Log ex

                Debug.WriteLine(ex.Message);
                return false;
            }
        }
        public virtual bool Delete(TKey id)
        {
            try
            {
                _connection.Execute(DeleteCommand,
                                       new
                                       {
                                           Id = id
                                       }, _transaction);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        protected virtual IEnumerable<U> ExecSp<U>(string cmd, object param)
        {

            return _connection.Query<U>(cmd, param, _transaction);
        }

        protected virtual IEnumerable<U> ExecSp<U>(string cmd)
        {
            return _connection.Query<U>(cmd, null, _transaction);
        }

        protected virtual U ScalarSp<U>(string cmd, object param)
        {
            var rep = _connection.Query<U>(cmd, param, _transaction);

            return default(U);

        }

        protected virtual object ScalarQuery(string cmd)
        {
            return _connection.ExecuteScalar<object>(cmd, null, _transaction);
        }


        protected object FieldToCollumn(T element)
        {
            var eo = new ExpandoObject();
            var eoColl = (ICollection<KeyValuePair<string, object>>)eo;

            foreach (PropertyInfo pInfo in typeof(T).GetProperties())
            {
                if (pInfo.Name != "Id")
                {
                    eoColl.Add(new KeyValuePair<string, object>(pInfo.Name, pInfo.GetValue(element)));
                }
            }

            dynamic eoDynamic = eo;

            return eoDynamic;
        }

    }
}


