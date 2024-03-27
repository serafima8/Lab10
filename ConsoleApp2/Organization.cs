﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Organization
    {
        public string Name { get; set; }
        public Organization() { }
        public Organization(string name)
        {
            this.Name = name;
        }
        public abstract void Print();
    }
}
