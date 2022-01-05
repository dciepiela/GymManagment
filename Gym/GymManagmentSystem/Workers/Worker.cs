using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagmentSystem.Workers
{
    internal class Worker
    {
        public string firstName;
        public string lastName;
        public string address;
        public string phone;
        public string email;
        public string function;
        private double salary;

        public double Salary { get => salary; set => salary = value; }

       
    }
}
