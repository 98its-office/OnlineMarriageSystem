using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1_nunit.Framework.Framework_GenericUtility
{
    internal interface IPathConstants
    {
        public static string ExcelPath = "C:\\Users\\HP\\source\\repos\\OnlineMarriageSystemNew\\OnlineMarriageSystem\\TestData\\matrimony1.xlsx";
        public static string jsonpath = "C:\\Users\\HP\\source\\repos\\OnlineMarriageSystemNew\\OnlineMarriageSystem\\TestData\\CommonData.json";
        //public static string basePath = AppDomain.CurrentDomain.BaseDirectory; // Gets the base directory of the project
        //public static string jsonpath = Path.Combine(basePath, "TestData", "CommonData.json");
        public static int sec = 20;
        public static string husbImagePath = "C:\\Users\\HP\\Source\\Repos\\OnlineMarriageSystemNew\\OnlineMarriageSystem\\TestData\\HD-wallpaper-salman-khan-tiger.jpg";
        public static string wifImagePath = "C:\\Users\\HP\\Source\\Repos\\OnlineMarriageSystemNew\\OnlineMarriageSystem\\TestData\\Nandini_2024-8-3-6-4-54_thumbnail.jpg";
    }
}
