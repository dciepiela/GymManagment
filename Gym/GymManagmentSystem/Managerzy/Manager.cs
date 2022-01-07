using GymManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GymManagmentSystem.Managerzy
{
    internal class Manager
    {
        //kompozycja
        protected Customer[] customers;
        protected Worker[] workers;
        protected Equipment[] equipments;

        protected int numberOfCustomers;
        protected int numberOfWorkers;
        protected int numberOfEquipments;

        public Manager(int sizeOfBase)
        {
            customers = new Customer[sizeOfBase];
            workers = new Worker[sizeOfBase];
            equipments = new Equipment[sizeOfBase];

        }

        public virtual void Add() { }
        public virtual void List() { }
        public virtual void Edit() { }
        public virtual void Remove() { }

        protected void Title(string title)
        {
            Console.Clear();
            Console.WriteLine($"******** {title.ToUpper()} ********");
            Console.WriteLine();
        }
    }
}
