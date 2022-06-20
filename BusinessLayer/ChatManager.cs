using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class ChatManager : BaseManager<ChatManager>
    {
        public static string ExtraFieldInChatManager = "Extra Field In Chat Manager";

        static ChatManager()
        {
            TableName = "tblChat";
            ManagerName = "ChatManager";
        }

        public static List<string> Listing(int userPkey1, int userPkey2)
        {
            Console.WriteLine($"By {ManagerName}, {DataManager.ServiceName()}\t| Get Chat List between {userPkey1} & {userPkey2}");

            var dt = DataManager.GetList($"(fromUser='{userPkey1}' and toUser='{userPkey2}') or (fromUser='{userPkey2}' and toUser='{userPkey1}')");
            
            return new List<string> { "chat list" };
        }
    }
}
