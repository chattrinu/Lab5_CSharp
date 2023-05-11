using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattrin_Udomsomporn_Ex03
{
    internal class EmployeeList
    {
        public string name { get; }
        public int id { get; }
        public double salary { get; }

        public EmployeeList (string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }


        public override string ToString() => $"{name,-10}{id,-10}{salary.ToString("C2",CultureInfo.CurrentCulture),-10}";
        
    }
}
