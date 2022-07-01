using System;
using System.Collections.Generic;
using DependencyInjection;
using System.Data;
using DataLayer;


namespace BusinessLayer
{
    public class BaseManager<CRTP> : CommonBaseManager where CRTP : BaseManager<CRTP>
    {
        public static string TableName;
        public static string ManagerName;
        public static BaseData DataManager = DefaultDataManager; // singleton

        static BaseManager()
        {
            Activator.CreateInstance<CRTP>();
        }

        public static string GetValue(int userKey, string columnName)
        {
            var dt = DataManager.GetList($"select {columnName} from {TableName} where userPkey='{userKey}'");

            Console.WriteLine($"By {ManagerName}, {DataManager.ServiceName()}\t| Get Result of [{userKey}][{columnName}] from [{TableName}]");

            return "";
        }

        public static DataTable GetList(string criteria)
        {
            Console.WriteLine($"By {ManagerName}, {DataManager.ServiceName()}\t| Get List with {criteria} from [{TableName}]");
            return DataManager.GetList($"select * from {TableName} where {criteria}");
        }

        public static bool SetValue<T>(int userKey, string columnName, T newValue)
        {
            var result = DataManager.Update(new DataTable());

            Console.WriteLine($"By {ManagerName}, {DataManager.ServiceName()}\t| Set {newValue} => [{userKey}][{columnName}] from [{TableName}] | {(result ? "Success" : "Failure")}");

            return result;
        }

    }

}
