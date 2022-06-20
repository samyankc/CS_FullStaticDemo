using System;
using System.Collections.Generic;
using System.Data;

namespace DependencyInjection
{
    public class OleDbService : IDbService
    {
        public DataTable ReadDataFromQuery(string sqlString) { return new DataTable(); }
        public bool ExecuteQuery(string sqlString) { return true; }
        public bool UpdateTable(DataTable updatedTable) { return true; }
        public string GetServiceClassName() { return "OleDbService"; }
    }
}
