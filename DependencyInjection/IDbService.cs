using System;
using System.Collections.Generic;
using System.Data;

namespace DependencyInjection
{
    public interface IDbService
    {
        DataTable ReadDataFromQuery(string sqlString);
        bool ExecuteQuery(string sqlString);
        bool UpdateTable(DataTable updatedTable);
        string GetServiceClassName();
    }

    public class DbServiceContainer<T> where T : IDbService
    {
        public static T Service = Activator.CreateInstance<T>();
    }
}
