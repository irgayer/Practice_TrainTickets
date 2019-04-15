using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_TrainTickets
{
    public class TrainTicketStore
    {
        const string STORE_NAME = "V PoEZDE";

        private List<Ticket> tickets;
        private List<Ticket> cart;


        private List<Ticket> GetTickets()
        {
            List<Ticket> result = new List<Ticket>();
            using (var context = new AppContext())
            {
                result = context.Tickets.ToList();
            }
            foreach(var c in result)
            {
                Console.WriteLine(c.Id);
            }
            return result;
        }

        private void DeleteTicket(Ticket index)
        {
            using(var context = new AppContext())
            {
                context.Tickets.Remove(index);
                context.SaveChanges();
            }
        }

        public void Run()
        {
            tickets = GetTickets();
            cart = new List<Ticket>();

            Console.WriteLine($"Добро пожаловать в магазин Ж/Д билетов \"{STORE_NAME}\"");
            while (true)
            {
                int menu;
                int toBuyTicketIndex;

                int innerMenu;

                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1) Купить билеты");
                Console.WriteLine("2) Выйти");
                

                if(int.TryParse(Console.ReadLine(),out menu))
                {
                    switch (menu)
                    {
                        case 1:
                            {
                                if (tickets.Count > 0)
                                {
                                    while (true)
                                    {
                                        Console.WriteLine("1) Купить");
                                        Console.WriteLine("2) Перейти к оплате");
                                        if (int.TryParse(Console.ReadLine(), out innerMenu))
                                        {
                                            if (innerMenu == 2)
                                            {
                                                break;
                                            }
                                        }

                                        for (int i = 0; i < tickets.Count; i++)
                                        {
                                            Console.WriteLine($"{i + 1})");
                                            tickets[i].Print();
                                            Console.WriteLine();
                                        }

                                        Console.WriteLine("Выберите номер билета: ");
                                        if (int.TryParse(Console.ReadLine(), out toBuyTicketIndex))
                                        {
                                            if (toBuyTicketIndex > 0 && toBuyTicketIndex <= tickets.Count)
                                            {
                                                cart.Add(tickets[toBuyTicketIndex - 1]);
                                                DeleteTicket(tickets[toBuyTicketIndex - 1]);
                                            }
                                        } 
                                    }
                                    if(cart.Count > 0)
                                    {
                                        int sum = 0;
                                        Console.WriteLine("Ваши билеты:");
                                        foreach(var t in cart)
                                        {
                                            t.Print();
                                            sum += t.Price;
                                        }
                                        Console.WriteLine($"К оплате: {sum}");
                                        
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Извините билетов нет!");
                                }
                                break;
                            }
                        case 2:
                            {
                                Environment.Exit(0);
                                break;
                            }
                    }
                }
            }
        }
    }
}
