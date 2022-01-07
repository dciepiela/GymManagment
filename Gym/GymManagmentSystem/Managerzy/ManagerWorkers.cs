using GymManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagmentSystem.Managerzy
{
    internal class ManagerWorkers:Manager
    {
        public ManagerWorkers(int siezeOfBase): base(siezeOfBase)
        {
        }
        public override void Add()
        {
            Title("panel dodawania nowych pracowników siłowni");
            Worker worker = new Worker();
            try
            {
                Console.Write("Imie      : "); worker.firstName = Console.ReadLine();
                Console.Write("Nazwisko  : "); worker.lastName = Console.ReadLine();
                Console.Write("Adres     : "); worker.address = Console.ReadLine();
                Console.Write("Telefon   : "); worker.phone = Console.ReadLine();
                Console.Write("Stanowisko: "); worker.function = Console.ReadLine();
                Console.Write("Email     : "); worker.email = Console.ReadLine();
                Console.Write("Pensja    : "); worker.Salary = double.Parse(Console.ReadLine());

                workers[numberOfWorkers++] = worker;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Nowy pracownik został dodany.");
                System.Threading.Thread.Sleep(500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Add();
            }
            
        }


        public override void List()
        {
            Title("Lista pracowników siłowni");

            if (numberOfWorkers > 0)
            {
                for (int i = 0; i < numberOfWorkers; i++)
                {
                    if(workers[i] == null)
                    {
                        continue;
                    }
                    Console.WriteLine($"{i + 1}. {workers[i].firstName} {workers[i].lastName} {workers[i].phone} {workers[i].function} {workers[i].Salary} $");
                }
                Console.ReadKey();
            }
            else
            {
                Console.CursorVisible = false;
                Title("brak pracowników klubu");
                Console.ReadKey();
            }
        }

        public override void Edit()
        {
            Title("Edytuj klienta spośród widocznych poniżej");
            List();

            if (numberOfWorkers > 0)
            {
                Console.WriteLine("Którego studenta chcesz edytować? (PODAJ NUMER)");
                int indexOfWorker = Convert.ToInt32(Console.ReadLine());
                if (indexOfWorker <= numberOfWorkers || indexOfWorker > 0)
                {
                    for (int i = 0; i < indexOfWorker; i++)
                    {
                        if (i == indexOfWorker)
                        {
                            Console.WriteLine($"{workers[indexOfWorker - 1].firstName} {workers[indexOfWorker - 1].lastName}");


                            Console.Write("Imie      : "); workers[indexOfWorker - 1].firstName = Console.ReadLine();
                            Console.Write("Nazwisko  : "); workers[indexOfWorker - 1].lastName = Console.ReadLine();
                            Console.Write("Adres     : "); workers[indexOfWorker - 1].address = Console.ReadLine();
                            Console.Write("Telefon   : "); workers[indexOfWorker - 1].phone = Console.ReadLine();
                            Console.Write("Stanowisko: "); workers[indexOfWorker - 1].function = Console.ReadLine();
                            Console.Write("Email     : "); workers[indexOfWorker - 1].email = Console.ReadLine();
                            Console.Write("Pensja    : "); workers[indexOfWorker - 1].Salary = double.Parse(Console.ReadLine());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Niestety numer pracownika jest nieprawidłowy.");
                }
            }
            Console.ReadKey();
        }

        public override void Remove()
        {
            Title("Usuń pracownika spośród widocznych poniżej");
            List();

            if (numberOfWorkers > 0)
            {
                numberOfWorkers--;
                Console.WriteLine("Którego pracownika chcesz usunąć z klubu?");
                int indexOfWorker = Convert.ToInt32(Console.ReadLine()) - 1;
                var newWorkersArr = new Worker[workers.Length];
                for (int i = 0; i < workers.Length; i++)
                {
                    if (i == indexOfWorker)
                    {
                        continue;
                    }
                    newWorkersArr.Append(workers[i]);
                }
                workers = newWorkersArr;
            }
            else
            {
                Console.WriteLine("Niestety numer pracownika jest nieprawidłowy.");
            }
        }
    }
}
