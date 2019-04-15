using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_TrainTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainTicketStore ticketStore = new TrainTicketStore();

            //using(var context = new AppContext())
            //{
            //    context.Tickets.Add(new Ticket
            //    {
            //        From = "Nur-Sultan",
            //        To = "Almaty",
            //        DepartureDate = new DateTime(2019, 01, 02, 03, 50, 50),
            //        ArrivalDate = new DateTime(2019, 01, 07, 12, 10, 30),
            //        Price = 12000
            //    });
            //    context.Tickets.Add(new Ticket
            //    {
            //        From = "Urumchi",
            //        To = "Pavlodar",
            //        DepartureDate = new DateTime(2019, 01, 02, 03, 50, 50),
            //        ArrivalDate = new DateTime(2019, 01, 07, 12, 10, 30),
            //        Price = 12000
            //    });
            //    context.Tickets.Add(new Ticket
            //    {
            //        From = "Almaty",
            //        To = "Nur-Sultan",
            //        DepartureDate = new DateTime(2019, 01, 02, 03, 50, 50),
            //        ArrivalDate = new DateTime(2019, 01, 07, 12, 10, 30),
            //        Price = 12000
            //    });
            //    context.SaveChanges();
            //}
            ticketStore.Run();
        }
    }
}
