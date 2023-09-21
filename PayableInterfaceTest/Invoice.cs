using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayableInterfaceTest
{
    //invoice class implements IPayable
    public class Invoice : IPayable
    {
        public string PartNumber { get; }
        public string PartDescription { get; }
        private int quantity;
        private decimal pricePerItem;

        //Four parameter constructor
        public Invoice(string partNumber, string Deescription, int cuantity, decimal pricePerItem)
        {
            this.PartNumber = partNumber;
            this.PartDescription = Deescription;
            this.Quantity = cuantity;
            this.PricePerItem = pricePerItem;
        }
        //Property that get and set the quantity on the invoice
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Quantity)} must be >=0 ");
                }
                quantity = value;
            }
        }
        //Property that set and get the pricePerItem on the invoice
        public decimal PricePerItem
        {
            get { return pricePerItem; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value,$"{nameof(PricePerItem)} must be >= o") ;
                }
                pricePerItem = value;
            }
        }

        //return string representation of invoice object
        public override string ToString() => $"invoice: \npart number: {PartNumber} ({PartDescription})\n" + $"Quantity: {Quantity}\nprice per item: {PricePerItem:C}";

        //method required to carry out contract with interface IPayable
        public decimal GetPaymentAmount() => Quantity * PricePerItem;
        
    }
}
