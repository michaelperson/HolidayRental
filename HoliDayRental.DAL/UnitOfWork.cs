using HoliDayRental.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL
{
    public class UnitOfWork : IUnitOfWork
    {

        private IDbConnection _connection;
        private IDbTransaction _transaction;

        public UnitOfWork(string connectionString)
        {
            try
            {
                _connection = new SqlConnection(connectionString);
                _connection.Open();
                _transaction = _connection.BeginTransaction();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }

        }

        public bool Commit()
        {
            bool isOk = false;
            try
            {
                _transaction.Commit();
                isOk = true;
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                _transaction.Dispose();
                _transaction = _connection.BeginTransaction();
            }
            return isOk;
        }

        protected virtual void Dispose(bool info = true)
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }

            if (_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
            GC.SuppressFinalize(this); // appel du Garbage Collector qui peut supprimer l'objet 
        }

        public void Dispose()
        {
            Dispose(true);
        }


        public MembreRepository MembreRepository =>  new MembreRepository(_transaction); 
    

    public AvisMembreBienRepository AvisMembreBienRepository => new AvisMembreBienRepository(_transaction);

        public BienEchangeRepository BienEchangeRepository => new BienEchangeRepository(_transaction);

        public MembreBienEchangeRepository MembreBienEchangeRepository => new MembreBienEchangeRepository(_transaction);

        public OptionsBienRepository OptionsBienRepository => new OptionsBienRepository(_transaction);

        public OptionsRepository OptionsRepository => new OptionsRepository(_transaction);

        public PaysRepository PaysRepository => new PaysRepository(_transaction);
    }
}

