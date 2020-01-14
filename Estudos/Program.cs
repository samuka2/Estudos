using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1:         " + d1);
            Console.WriteLine("d1 kind     " + d1.Kind);
            Console.WriteLine("d1 to Local:" + d1.ToLocalTime());
            Console.WriteLine("d1 to Utc   " + d1.ToUniversalTime());

        }
    }
}
