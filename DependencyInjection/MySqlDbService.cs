using System;
using System.Collections.Generic;
using System.Data;

namespace DependencyInjection
{
    public class MySqlDbService : IDbService
    {
        public DataTable ReadDataFromQuery(string sqlString) { return new DataTable(); }
        public bool ExecuteQuery(string sqlString) { return false; }
        public bool UpdateTable(DataTable updatedTable) { return false; }
        public string GetServiceClassName() { return "MySqlDbService"; }
    }
}
