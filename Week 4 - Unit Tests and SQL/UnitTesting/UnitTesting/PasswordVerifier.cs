using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    internal class PasswordVerifier
    {
        public bool Verify(string password)
        {
            bool notNull = password != null;
            //Not null check has to happen first, as the other conditions will throw an exception 
            //if we are null
            if (notNull)
            {
                bool longEnough = password.Length >= 8;
                bool hasUpper = HasUppercase(password);
                bool hasLower = HasLowercase(password);
                if (longEnough && hasUpper && hasLower)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return false;
        }

        public bool HasUppercase(string password)
        {
            foreach(char letter in password)
            {
                bool b = char.IsUpper(letter);
                if(b == true)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasLowercase(string password)
        {
            foreach (char letter in password)
            {
                bool b = char.IsLower(letter);
                if (b == true)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
