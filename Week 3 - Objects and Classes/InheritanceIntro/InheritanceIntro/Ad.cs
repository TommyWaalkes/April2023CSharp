using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    class Ad : Mail
    {
        public Ad(string ReturnAddress, string RecipientAddress, string Content, DateTime Date) : base(ReturnAddress, RecipientAddress, Content, Date)
        {
        }
    }
}
