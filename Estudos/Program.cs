using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos.Entities;
using Estudos.Entities.Enums;

namespace Estudos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter departmet's name: ");
            string dtName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior)");
            WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());

        }
    }
}
