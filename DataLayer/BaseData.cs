using System;
using DependencyInjection;
using System.Data;

namespace DataLayer
{
    public class BaseData
    {
        protected IDbService DbService;

        public BaseData(IDbService ChosenService)
        {
            if (ChosenService != null)
                DbService = ChosenService;
            else 
                DbService = DbServiceContainer<OleDbService>.Service;
        }

        public string ServiceName()
        {
            return DbService.GetServiceClassName();
        }

        public DataTable GetList(string query)
        {
            return DbService.ReadDataFromQuery(query);
        }
        public bool Execute(string query)
        {
            return DbService.ExecuteQuery(query);
        }

        public bool Update(DataTable updatedTable)
        {
            return DbService.UpdateTable(updatedTable);
        }


    }
}
