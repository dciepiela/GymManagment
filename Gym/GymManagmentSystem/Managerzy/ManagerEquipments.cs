using GymManagmentSystem.Models;
using System;
using System.Linq;

namespace GymManagmentSystem.Managerzy
{
    internal class ManagerEquipments:Manager
    {
        public ManagerEquipments(int sizeOfBase): base(sizeOfBase)
        {
        }

        public override void Add()
        {
            try
            {
                Title("panel dodawania nowego sprzętu na siłowni");
                Equipment equipment = new Equipment();
                Console.Write("Nazwa : "); equipment.name = Console.ReadLine();
                Console.Write("Cena  : "); equipment.Value = Convert.ToDouble(Console.ReadLine());

                equipments[numberOfEquipments++] = equipment;
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Nowy sprzęt został dodany do klubu.");
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
            Title("Lista dostępnych sprzętów na siłowni");
            
            if (numberOfEquipments > 0)
            {
                for (int i = 0; i < numberOfEquipments; i++)
                {
                    if(equipments[i] is null)
                    {
                        continue;
                    }
                    Console.WriteLine($"{i + 1}. {equipments[i].name} {equipments[i].Value}$");
                }
                Console.ReadKey();
            }
            else
            {
                Console.CursorVisible = false;
                Title("brak sprzętu w klubie");
                Console.ReadKey();
            }
        }
        public override void Edit()
        {
            Title("Edytuj klienta spośród widocznych poniżej");
            List();

            if (numberOfEquipments > 0)
            {
                Console.WriteLine("Którego studenta chcesz edytować? (PODAJ NUMER)");
                int indexOfEquipment = Convert.ToInt32(Console.ReadLine());
                if (indexOfEquipment <= numberOfEquipments || indexOfEquipment > 0)
                {
                    for (int i = 0; i < indexOfEquipment; i++)
                    {
                        if (i == indexOfEquipment)
                        {
                            Console.WriteLine($"{equipments[indexOfEquipment - 1].name} {equipments[indexOfEquipment - 1].Value}");

                            Console.Write("Nazwa :"); equipments[indexOfEquipment - 1].name = Console.ReadLine();
                            Console.Write("Cena  :"); equipments[indexOfEquipment - 1].Value = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                }
                else
                {
                    Title("Numer urządzenia jest nieprawidłowy.");
                }
            }
            Console.ReadKey();
        }

        public override void Remove()
        {
            Title("Usuń sprzęt spośród widocznych poniżej");
            List();

            if (numberOfEquipments > 0)
            {
                Console.WriteLine("Który sprzęt chcesz usunąć z klubu?");
                int indexOfEquipment = Convert.ToInt32(Console.ReadLine()) - 1;
                var newEquipmentsArr = new Equipment[equipments.Length];
                numberOfEquipments--;
                for (int i = 0; i < equipments.Length; i++)
                {
                    if (i == indexOfEquipment)
                    {
                        continue;
                    }
                    newEquipmentsArr.Append(equipments[i]);
                }
                equipments = newEquipmentsArr;
            }
            else
            {
                Console.WriteLine("Niestety numer pracownika jest nieprawidłowy.");
            }
        }
    }
}
