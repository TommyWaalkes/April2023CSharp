namespace InheritanceIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mail m = new Mail("1234 Walabee way", "456 Sitcks RD", "We are learning inheritance.", new DateTime(2023, 3, 14));
            //m.ReadContent();

            Bill b = new Bill("1234 Street RD", "Tommy's apartment", "Pay up, or we're sending you spam mail", DateTime.Now, 1000.01);
            //b.ReadContent();

            JunkMail jm = new JunkMail("Not a Front", "Your house", "Cash for money now, give us your old cash, and we'll give you money!", DateTime.Now);
            //jm.ReadContent();
            Ad a = new Ad("Legit Business", "Your house", "Hello buy something", DateTime.Now.AddDays(1));

            List<Mail> mailBag = new List<Mail>() { m,b,jm,a };

            foreach(Mail letter in mailBag)
            {
                //When readContent is called, C# checks the current class first for its definition, 
                //Then C#, if doesn't find a definition, will go up to the current classes direct parent and search there.
                //If nothing is found, repeat until you a) find the method or b) run out of parents. 
                letter.ReadContent();
                Console.WriteLine();
            }
            
        }
    }
}