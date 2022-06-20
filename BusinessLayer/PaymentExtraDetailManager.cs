using System;
using System.Collections.Generic;
using System.Linq;
using DependencyInjection;
using DataLayer;

namespace BusinessLayer
{
    public class PaymentExtraDetailManager : PaymentManager_<PaymentExtraDetailManager>
    {
        // Adding new DataManager along side with the current one
        protected static BaseData ExtraDataManager = new BaseData(DbServiceContainer<MySqlDbService>.Service);
        static PaymentExtraDetailManager()
        {
            TableName = "tblPaymentExtra";
            ManagerName = "PaymentExtraDetailManager";
        }

        public static string GetRecurringID(string TransactionID)
        {
            Console.WriteLine($"By {ManagerName}, {DataManager.ServiceName()}\t| Get Recurring ID from {TransactionID}");
            
            var dt = GetList($"TransactionID='{TransactionID}'");
            
            return "88888";
            
        }

        public static string AnotherGetRecurringID(string TransactionID)
        {
            // using both services
            Console.WriteLine($"By {ManagerName}, {DataManager.ServiceName()}\t| Get Recurring ID from {TransactionID} from [{TableName}]");
            Console.WriteLine($"By {ManagerName}, {ExtraDataManager.ServiceName()}\t| Get Recurring ID from {TransactionID} from [{TableName}]");
            return "";
        }



    }
}
