using System;

namespace FirstUnitTestingNetcore
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static string Something()
        {
            return "something";
        }

        public static bool Login(string user, string pass) =>
            user == "ariel" && pass == "123456" ? true : false;
    }
}
