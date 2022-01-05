using GymManagmentSystem.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagmentSystem.Managerzy
{
    internal class ManagerCustomers:Manager
    {
        public ManagerCustomers(int sizeOfBase):base(sizeOfBase)
        {
        }

        public override void Add()
        {
            Title("panel dodawania nowych członków siłowni");
            Customer customer = new Customer();

            Console.Write("Imie    : "); customer.firstName = Console.ReadLine();
            Console.Write("Nazwisko: "); customer.lastName = Console.ReadLine();
            Console.Write("Adres   : "); customer.address = Console.ReadLine();
            Console.Write("Telefon : "); customer.phone = Console.ReadLine();
            Console.Write("Email   : "); customer.email = Console.ReadLine();

            customers[numberOfCustomers++] = customer;
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Nowy klient został dodany");
            System.Threading.Thread.Sleep(500);
        }

        public override void List()
        {
            Title("Lista klientów siłowni");
            if (numberOfCustomers > 0)
            {
                for (int i = 0; i < numberOfCustomers; i++)
                {
                    Console.WriteLine($"{i + 1}. {customers[i].firstName} {customers[i].lastName} {customers[i].phone}");
                }
                Console.ReadKey();
            }
            else 
            {
                Console.CursorVisible = false;
                Title("brak członkó" +
                    "w klubu");
                Console.ReadKey();
            }
        }
        public override void Edit()
        {
            Title("Edytuj klienta spośród widocznych poniżej");
            List();

            if (numberOfCustomers > 0)
            {
                Console.WriteLine("Którego studenta chcesz edytować? (PODAJ NUMER)");
                int indexOfCustomer = Convert.ToInt32(Console.ReadLine());
                if (indexOfCustomer <= numberOfCustomers && indexOfCustomer > 0)
                {
                    for (int i = 1; i <= indexOfCustomer; i++)
                    {
                        if (i == indexOfCustomer)
                        {
                            Console.WriteLine($"Wybrałeś: {customers[indexOfCustomer - 1].firstName} {customers[indexOfCustomer - 1].lastName}");

                            Console.Write("Imie      :"); customers[indexOfCustomer - 1].firstName = Console.ReadLine();
                            Console.Write("Nazwisko  :"); customers[indexOfCustomer - 1].lastName = Console.ReadLine();
                            Console.Write("Adres   : "); customers[indexOfCustomer - 1].address = Console.ReadLine();
                            Console.Write("Telefon : "); customers[indexOfCustomer - 1].phone = Console.ReadLine();
                            Console.Write("Email   : "); customers[indexOfCustomer - 1].email = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Niestety numer pracownika jest nieprawidłowy.");
                }
            }

        }
        public override void Remove()
        {
            Title("Usuń klienta spośród widocznych poniżej");
            List();
            
            if(numberOfCustomers > 0)
            {
                Console.WriteLine("Którego członka chcesz usunąć z klubu?");
                int indexOfCustomer = Convert.ToInt32(Console.ReadLine());
                if (indexOfCustomer <= numberOfCustomers && indexOfCustomer > 0)
                {
                    for (int i = 1; i <= indexOfCustomer; i++)
                    {
                        if(i == indexOfCustomer )
                        {
                            
                            Console.ReadKey();
                            //Console.WriteLine($"Wybrałeś: {customers[indexOfCustomer - 1].firstName} {customers[indexOfCustomer - 1].lastName}");

                            //Console.Write("Imie      :"); customers[indexOfCustomer - 1].firstName = Console.ReadLine();
                            //Console.Write("Nazwisko  :"); customers[indexOfCustomer - 1].lastName = Console.ReadLine();
                            //Console.Write("Adres   : "); customers[indexOfCustomer - 1].address = Console.ReadLine();
                            //Console.Write("Telefon : "); customers[indexOfCustomer - 1].phone = Console.ReadLine();
                            //Console.Write("Email   : "); customers[indexOfCustomer - 1].email = Console.ReadLine();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Niestety numer pracownika jest nieprawidłowy.");
            }
        }
    }
}
