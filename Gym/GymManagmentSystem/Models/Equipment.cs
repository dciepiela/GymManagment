﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagmentSystem.Models
{
    internal class Equipment
    {
        public string name;
        private double value;

        public double Value { get => value; set => this.value = value; }
    }
}
