using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chattrin_Udomsomporn_Ex02
{
    internal class InvoiceItem
    {
        public int PartNumber { get;  }
        public string PartDescription { get; }
        public int Quantity { get;  }
        public decimal Price { get; }

        public InvoiceItem(int partNumber, string partDescription, int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }
        public override string ToString() => $"{PartNumber,-10}{PartDescription,-20}{Quantity,-10}{Price,-10}";
       
    }
}
