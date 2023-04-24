using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    class Bill : Mail
    {
        public double AmountDue { get; set; }
        public Bill(string ReturnAddress, string RecipientAddress, string Content, DateTime Date, double AmountDue) 
            //Base is a pointer to our parent
            //Our Parent requires those parameters and this is how we pass those parameter up to our parent
            //If our parent has a constructor, the child must fill it in using the base keyword
            : base(ReturnAddress, RecipientAddress, Content, Date)
        {
            this.AmountDue = AmountDue;
        }

        public override void ReadContent()
        {
            //Call the parent's version of this method 
            base.ReadContent();

            //Then lets our own lines for bill 
            Console.WriteLine("Amount Due: $" + AmountDue);
            Console.WriteLine("Send checks to: " + ReturnAddress);
        }
    }
}
