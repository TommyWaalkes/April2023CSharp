using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    class JunkMail : Mail
    {
        DateTime OfferEnd { get; set; }
        public JunkMail(string ReturnAddress, string RecipientAddress, string Content, DateTime Date) : base(ReturnAddress, RecipientAddress, Content, Date)
        {
            OfferEnd = DateTime.Now.AddHours(1);
        }

        public override void ReadContent()
        {
            while (true)
            {
                base.ReadContent();
                Console.WriteLine("Current time: " + DateTime.Now);
                Console.WriteLine("Act Fast offer ends : " + OfferEnd);
                //Console.Clear();
                break;
            }
        }
    }
}
