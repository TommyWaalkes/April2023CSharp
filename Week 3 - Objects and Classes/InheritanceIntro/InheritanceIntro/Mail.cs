using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    class Mail
    {
        //If you don't put an access modifier on a method or property, it defaults to private, meaning it can only be used in the same class 
        //We need to set our properties to public 
        //There's also a protected modifier, which only the same class and its children may use the variable.
        public string ReturnAddress { get; set; }
        public string RecipientAddress { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Mail(string ReturnAddress, string RecipientAddress, string Content, DateTime Date)
        {
            this.ReturnAddress = ReturnAddress;
            this.RecipientAddress = RecipientAddress;
            this.Content = Content;
            this.Date = Date;
        }

        public virtual void ReadContent()
        {
            Console.WriteLine(Date);
            Console.WriteLine(Content);
        }
    }
}
