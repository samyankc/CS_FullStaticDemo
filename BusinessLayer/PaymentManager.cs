﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class PaymentManager_<CRTP> : BaseManager<PaymentManager_<CRTP>>
    {
        static PaymentManager_()
        {
            TableName = "tblPayment";
            ManagerName = "PaymentManager";
            typeof(CRTP).TypeInitializer?.Invoke(null, null);
        }

        public static List<string> GetTransactionIDs(int userPkey)
        {
            Console.WriteLine($"By {ManagerName}, {DataManager.ServiceName()}\t| Get TransactionID List from {userPkey}");

            var dt = GetList($"userPkey='{userPkey}'");

            return new List<string> { "999999" };
        }
    }

    public class PaymentManager : PaymentManager_<PaymentManager>{}
}
