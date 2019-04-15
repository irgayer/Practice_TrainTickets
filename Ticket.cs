using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_TrainTickets
{
    public class Ticket : Entity
    {
        public string HolderName { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Price { get; set; }
        public bool IsAvailable {
            get
            {
                if (!string.IsNullOrWhiteSpace(HolderName))
                {
                    return true;
                }
                return false;
            }
        }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }  

        public void Print()
        {
            Console.WriteLine($"Откуда        : {From}");
            Console.WriteLine($"Куда          : {To}");
            Console.WriteLine($"Цена          : {Price}");
            Console.WriteLine($"Дата отбытия  : {DepartureDate}");
            Console.WriteLine($"Дата прибытия : {ArrivalDate}");
        }
    }
}
