using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class UserManager : BaseManager<UserManager>
    {
        static UserManager()
        {
            TableName = "tblUser";
            ManagerName = "UserManager";
        }

        public static string GetCountry(int userKey)
        {
            return GetValue(userKey, "country").ToLower();
        }

        public static bool ChangeCountry(int userKey, string newCountry)
        {
            SetValue(userKey, "country", newCountry);
            return true;
        }

        public static string GetGender(int userKey)
        {
            return GetValue(userKey, "gender").ToLower();
        }

        public static bool IsMale(int userKey)
        {
            return GetGender(userKey) == "male";
        }

        public static bool IsFemale(int userKey)
        {
            return GetGender(userKey) == "female";
        }
    }
}
