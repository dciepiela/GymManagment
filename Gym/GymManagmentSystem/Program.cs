using GUITools;
using GymManagmentSystem.Managerzy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            Console.Write("Podaj login: ");
            login = Console.ReadLine();
            Console.Write("Podaj hasło: ");
            password = Console.ReadLine();
            
            if (login == "admin" && password == "admin")
            {
                Console.WriteLine("Zalogowano pomyślnie");
                System.Threading.Thread.Sleep(1000);
                Menu menu = new Menu();
                ManagerCustomers customers = new ManagerCustomers(20);
                ManagerWorkers workers = new ManagerWorkers(20);
                ManagerEquipments equipments = new ManagerEquipments(20);


                menu.Configure(new string[]
                {
                "Dodaj nowego członka",
                "Dodaj nowego pracownika",
                "Dodaj nowy sprzęt",
                "Wyświetl członka",
                "Wyświetl pracownika",
                "Wyświetl obecny sprzęt",
                "Edytowanie",
                "Usuwanie",
                "Zakończ program"});

                int decision;
                do
                {
                    Console.Clear();
                    decision = menu.OpenMenu();
                    if (decision == 0)
                    {
                        customers.Add();
                    }
                    else if (decision == 1)
                    {
                        workers.Add();
                    }
                    else if (decision == 2)
                    {
                        equipments.Add();
                    }
                    else if (decision == 3)
                    {
                        customers.List();
                    }
                    else if (decision == 4)
                    {
                        workers.List();
                    }
                    else if (decision == 5)
                    {
                        equipments.List();
                    }
                    else if (decision == 6)
                    {
                        Menu menuToEdit = new SecondMenu();
                        menuToEdit.Configure(new string[] {
                            "Edycja członka klubu",
                            "Edycja pracownika klubu",
                            "Edycja sprzętu w klubie"});
                        int decisionToEdit;
                        do
                        {
                            Console.Clear();
                            decisionToEdit = menuToEdit.OpenMenu();
                            if(decisionToEdit == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Edycja członka klubu");
                                customers.Edit();
                            }
                            else if (decisionToEdit == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Edycja pracownika klubu");
                                workers.Edit();
                            }
                            else if (decisionToEdit == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Edycja sprzętu w klubie");
                                equipments.Edit();
                            }
                        }
                        while(decisionToEdit != -1 && decisionToEdit != 3);
                    }
                    else if (decision == 7)
                    {
                        Menu menuToRemove = new SecondMenu();
                        menuToRemove.Configure(new string[] {
                            "Usuwanie członka klubu",
                            "Usuwanie pracownika klubu",
                            "Usuwanie sprzętu w klubie"});
                        int decisionToRemove;
                        do
                        {
                            Console.Clear();
                            decisionToRemove = menuToRemove.OpenMenu();
                            if (decisionToRemove == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Usuwanie członka klubu");
                                customers.Remove();
                            }
                            else if (decisionToRemove == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Usuwanie pracownika klubu");
                                Console.ReadKey();
                            }
                            else if (decisionToRemove == 2)
                            {
                                Console.Clear();
                                Console.WriteLine("Usuwanie sprzętu w klubie");
                                Console.ReadKey();
                            }
                        }
                        while (decisionToRemove != -1 && decisionToRemove != 3);
                    }
                }
                while (decision != 8 && decision != -1);
            }
            else
            {
                Console.WriteLine("Niepoprawne dane do logowania!!!");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
