namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Concat Example
            string a = "hello";
            string b = "world";
            string combo = String.Concat(9, false);
            string combo2 = String.Concat(a, b);
            string combo3 = a + b;
            string nums = string.Concat(1, 1);

            //A string plus any number of other variable or literals converts everything into a string
            string nums2 = 1 + "" + 1;

            Console.WriteLine("Concat example:");
            Console.WriteLine("Concatenation means adding together two string OR a string and something else");
            Console.WriteLine("Just like anyone can be a developer, anything can be a string");

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("Using Concat Method:" + combo2);
            Console.WriteLine("Using Plus sign:" + combo3);
            Console.WriteLine("Concat nums: " + nums);
            Console.WriteLine("Using nums with the plus sign: " + nums2);
            Console.WriteLine();

            a = "test";
            b = "test";

            string c = "tommy";
            Console.WriteLine("Comparision Example:");
            Console.WriteLine("Note that in current C# == and .Equals are functionally the same");
            Console.WriteLine("In other languages and older versions of C# this may not be the case");
            Console.WriteLine("String A: " + a);
            Console.WriteLine("String B: " + b);
            Console.WriteLine("String C: " + c);
            Console.WriteLine("A compared to B");
            //== and the Equals method return the same result
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine();
            Console.WriteLine("B compared to C");
            Console.WriteLine(b == c);
            Console.WriteLine(b.Equals(c));
            Console.WriteLine();

            //Later on in the course ToArray and ToList will be very useful 
            Console.WriteLine("ToArray Example:");
            Console.WriteLine("At the end of the day, strings are just char[] arrays");
            Console.WriteLine("Before arrays existed, people just made a ton of char[] arrays");
            Console.WriteLine("Question: Why would you want to convert a string into a char[]?");

            a = "slim shady";
            //Character arrays allow you to change your string by index directly 
            char[] slim = a.ToArray();

            foreach (char s in slim)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            slim[0] = 't';
            Console.WriteLine(slim[0]);

            string slim2 = new string(slim);
            
            
            Console.WriteLine();
            Console.WriteLine("Substring Example:");
            Console.WriteLine("Substring is much like a film editor cutting film, you cut out and return a subsection of a string");

            a = "tommy waalkes";
            //Definitly one of the most useful string methods 
            //It allows you to cut out part of your string making rearranging

            //The first param of substring is the starting index, second param is how many spaces to the right you wish to go. 
            string sub = a.Substring(6,7);
            Console.WriteLine("Original String: " + a);
            Console.WriteLine("Substring: " + sub);

            Console.WriteLine();
            Console.WriteLine("IndexOf Example:");
            Console.WriteLine("IndexOf takes in a string and crawls through another string to try and find a match for the first string");
            Console.WriteLine("The method returns the first index where it finds a match. If nothing is found it returns the unniversal sign for errors: -1");

            a = "joey waalkes";
            //-1 is the universal sign of either not found or an error occurred while searching 
            int result = a.IndexOf("z");
            Console.WriteLine(result);
            if (a.Contains("j") || a.Contains("w"))
            {
                Console.WriteLine("We found joey's name");
            }

            

            Console.WriteLine();
            Console.WriteLine("ToLower and ToUpper Examples");
            Console.WriteLine("These methods take all the letters of string and convert them to upper or to lower case");
            Console.WriteLine("Question: how could toUpper or toLower be use when working with user input?");


            a = "FooBar";
            b = "barfoo";

            Console.WriteLine("Original Strings:");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("ToLower: ");
            Console.WriteLine(a.ToLower());
            Console.WriteLine(b.ToLower());
            Console.WriteLine("ToUpper: ");
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(b.ToUpper());


            Console.WriteLine();
            Console.WriteLine("Split Example: ");
            string name = "tommy waalkes is a teacher\t Burger king is the real king\t Taco Bell is fine cusine\t Ronald McDonald is scary";

            //if split is not given any parameters it will split along the spaces

            //Split without parameters will cut along spaces 
            string[] n = name.Split();
            Console.WriteLine(name);

            Console.WriteLine();
            Console.WriteLine("Split up string: ");
            foreach (string s in n)
            {
                Console.WriteLine(s);
            }

        }
    }
}
