using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HoliDayRental.DAL.Extensions
{
    public static class EntityExtension
    {

        /// <summary>
        /// Methode qui permet de retourner le nom de la proprieté qui est l'identifiant (Reflection)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static string GetPKey<T>()
        {
            PropertyInfo PI = typeof(T).GetProperties()
                                        .FirstOrDefault(p => p.CustomAttributes.Any(a => a.AttributeType.Name == "KeyAttribute"));

            return PI?.Name;
        }
    }
}

