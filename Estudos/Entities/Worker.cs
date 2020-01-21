using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudos.Entities.Enums;

namespace Estudos.Entities
{
    class Worker
    {
        public String Name { get; set; }
        public  WorkLevel  Level{ get; set; }

        public double BaseSalary { get; set; }

        //Associaando duas classes diferentes
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }
        public Worker(string name, WorkLevel leveL, double baseSalary, Departament departament )
        {
            Name        = name;
            Level       = leveL;
            BaseSalary  = baseSalary;
            Departament = departament;
        }


        //adicionando horas no contrato
        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        //removendo horas do contrato
        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int year, int month)
        {
            double sum = BaseSalary;

            //vou percorrer a lista
            foreach (HourContract contract in Contracts)
            {
                //se o contrato for igual a data e o mês mencionado
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }

            }
            return sum;
        }


    }
}
