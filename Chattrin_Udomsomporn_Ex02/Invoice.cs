using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattrin_Udomsomporn_Ex02
{
    internal class Invoice
    {
        static void Main(string[] args)
        {
            

            var itemInvoice = new[]
            {
                new InvoiceItem(87,"Electric Sander",7,57.98m),
                new InvoiceItem(24,"Power Saw",18,99.99m),
                new InvoiceItem(7,"Sledge Hammer",11,21.50m),
                new InvoiceItem(77,"Hammer",79,11.99m),
                new InvoiceItem(39,"Lawn Mower",3,79.50m),
                new InvoiceItem(68,"Scew Driver",106,6.99m),
                new InvoiceItem(56,"Hig saw",21,11.00m),
            };
            Console.WriteLine("Invoice Table");
            foreach (var item in itemInvoice)
            {
                Console.WriteLine(item);
            }



            // display part description and Price

            // order P Part Description and Price witj LINQ
            var DescriptionAndPrice = from e in itemInvoice
                                      select (e.PartDescription,e.Price);
                                      

            Console.WriteLine();
            Console.WriteLine(" A) Display Part Description and Price");
            foreach (var item in DescriptionAndPrice)
            {
                Console.WriteLine(item);
            }


            
           
            //display the total number of parts with LINQ
            Console.WriteLine();
            Console.WriteLine("B) Display Total number of parts: ");

            var totalNumber = from e in itemInvoice
                              select e.PartDescription;
            int count = 0;
             foreach (var item in totalNumber)
            {
                ++count;
            }
            Console.WriteLine(count);

            

            //Display the part with higest quantity with LINQ
            

            var HighQyt = from e in itemInvoice
                          orderby e.Quantity descending
                          select (e.PartDescription,e.Quantity);
            Console.WriteLine();
            Console.WriteLine(" C ) Display the part with highest Quantiy: ");
            if (HighQyt.Any())
            {
                Console.WriteLine(HighQyt.First());
            }
           else
            {
                Console.WriteLine("not found");
            }


            // display part lowest part number  with LINQ
            var LowNum = from e in itemInvoice
                         orderby e.PartNumber ascending
                         select (e.PartDescription,e.PartNumber);
            Console.WriteLine();
            Console.WriteLine(" D) Display part with lowest part number: ");
            if(LowNum.Any())
            {
                Console.WriteLine(LowNum.First());
            }
            else
            {
                Console.WriteLine("Not found");
            }
         
            


           
            
            

                                      
                                      
            

        }
    }
}
