using System;

namespace BusinessLayer
{
    public class CommonBaseManager
    {
        public static string SharedData = "This string is shared across all managers";
        public static string BaseVersion = "2022.06.20.14.50.32";
        protected static DataLayer.BaseData DefaultDataManager = new DataLayer.BaseData(null);
    }
}
