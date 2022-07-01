using System;
using BusinessLayer;

namespace FullStaticDemo
{
    using static Console;

    public class Program
    {

        public static void Main(string[] args)
        {

            int userPkey = 123321;
            int userPkey2 = 987654;
            
            UserManager.GetCountry(userPkey);
            UserManager.IsMale(userPkey);
            UserManager.ChangeCountry(userPkey, "HK");

            Console.WriteLine();
            ChatManager.Listing(userPkey, userPkey2);
            
            Console.WriteLine();
            PaymentManager.GetTransactionIDs(userPkey);

            Console.WriteLine();
            var TransID = PaymentDetailManager.GetTransactionIDs(userPkey)[0];
            PaymentDetailManager.GetRecurringID(TransID);

            Console.WriteLine();
            PaymentExtraDetailManager.GetRecurringID(TransID);
            PaymentExtraDetailManager.AnotherGetRecurringID(TransID);

            Console.ReadKey();
        }
    }
}

