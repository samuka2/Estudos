using System;
namespace Estudos.Entities
{
    class HourContract
    {
        public DateTime Date { get; set;}
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }


        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Calcula o total de horas 
        public double totalValue()
        {
            return 0;
        }
    }
    
}
