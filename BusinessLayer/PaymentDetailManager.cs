using System;
using System.Collections.Generic;
using System.Linq;
using DependencyInjection;
using DataLayer;

namespace BusinessLayer
{
    public class PaymentDetailManager : PaymentManager_<PaymentDetailManager>
    {


        static PaymentDetailManager()
        {
            // switching DbService
            DataManager = new BaseData(DbServiceContainer<MySqlDbService>.Service);

            // using the same TableName as PaymentManager_
            ManagerName = "PaymentDetailManager";
        }

        public static string GetRecurringID(string TransactionID)
        {
            Console.WriteLine($"By {ManagerName}, {DataManager.ServiceName()}\t| Get Recurring ID from {TransactionID}");
            
            var dt = GetList($"TransactionID='{TransactionID}'");

            return "888888";            
        }
    }
}
