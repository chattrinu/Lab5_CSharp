using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattrin_Udomsomporn_Ex03
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            var employee = new[]
            {
               new EmployeeList ("Tony",111111,6500),
               new EmployeeList ("Sara",222000,5700),
               new EmployeeList ("Scott",333111,6200),
               new EmployeeList ("Megan",444000,4900),
               new EmployeeList ("Alex",555111,5100)
            };
            
            // creating text file
            using(StreamWriter writer1 = new StreamWriter("Employee.txt"))
            {
                writer1.WriteLine($"Name      ID        Salary");
                foreach (var people in employee)
                {

                    writer1.WriteLine(people.ToString());
                    
                }
                   
                double sum=0;
                foreach ( var employeesalary in employee)
                {
                    
                    sum = sum + employeesalary.salary;
                }
                  writer1.WriteLine("Total Salary: "+sum);

                double average = 0;
                int totalemployee = 5;
                foreach (var employeesalary in employee)
                {

                    average = average + employeesalary.salary;
                }

                writer1.WriteLine("Average Salary: "+ Math.Round(average/totalemployee).ToString("C2",CultureInfo.CurrentCulture));

            }
           

            // reader file
            using ( StreamReader reader1 = new StreamReader("Employee.txt"))
            {
                var employeeInfo = reader1.ReadLine();
                while (employeeInfo != null)
                {
                    Console.WriteLine(employeeInfo);
                    employeeInfo = reader1.ReadLine();
                 }

                
            }
        }
    }
}
