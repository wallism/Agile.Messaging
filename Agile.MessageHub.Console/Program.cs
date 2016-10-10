using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agile.MessageHub.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = ConfigurationManager.AppSettings["Setting2"];
            System.Console.WriteLine(setting);

            var conn = ConfigurationManager.ConnectionStrings["Logging"];
            Console.WriteLine(conn);
            System.Console.ReadLine();
        }
    }
}
