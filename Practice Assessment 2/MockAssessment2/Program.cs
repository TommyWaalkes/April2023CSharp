namespace MockAssessment2
{
    public class Program
    {
        //Main is the main hook into our code, when we run our code, it starts atthe top of main and runs top to bottom
        //You won't be graded on what is in main, BUT it's very reccomended you use it to test your methods. 
        public static void Main()
        {
            string[] characters = { "Han", "Luke", "Palapatine" };
            int index = AddStarWarsCharacter(characters);
            Console.WriteLine(index);
            Console.WriteLine();
            Console.WriteLine("Method 2: Dictionary");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Yoda", 9001);
            dict.Add("Jar Jar", 120000);
            dict.Add("Luke", 10000000);
            string strongest = DeathStarCombat(dict);
            Console.WriteLine(strongest);
            string strongest2 = DeathStarCombatLinq(dict);
            Console.WriteLine(strongest2);
            Console.WriteLine();
            Console.WriteLine("Method 3");
            string[] planets = { "Tatooine", "Dagobah", "Hoth" };
            List<string> reversed = ConvertPlanets(planets);

            for(int i = 0; i < reversed.Count; i++)
            {
                Console.WriteLine(i +" "+reversed[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Long way of convert planets");
            List<string> reversed2 = ConvertPlanetsLongWay(planets);
            for (int i = 0; i < reversed2.Count; i++)
            {
                Console.WriteLine(i + " " + reversed2[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Method 4 Average Droids");
            List<int> droids = new List<int>() { 10, 15, 20, 25, 30, 35 };
            double average = AverageDroids(droids);
            Console.WriteLine(average);

            Console.WriteLine();
            Console.WriteLine("Method 5: Try to Catch Vader");
            string result1 = TryToCatchDarthVader("12");
            Console.WriteLine(result1);
            string result2 = TryToCatchDarthVader("dsghjregcvdf");
            Console.WriteLine(result2);
        }

        //1) Public -- Access Modifier, almost always want your methods to be public
        //2) Static --working without objects, our methods need to be static, static means the method is called via the class, 
        //more on this when we do objects 
        //3) Return Type -- This is what data type the method is intended to output. I am making a promise that my method will return 
        //a variable ot literal matching the return type, Visual Studio/C# will both hold us to that promise 
        //Say you intend NOT to return anything, then use the void keyword for the return type
        //4) Method Signature -- This acts as the name of our method and is how we call it elsewhere in our project. 
        //Usually you want to give methods names that are verbs so like Parse, Run, Convert, Print, Combine
        //It is worth it, to take a moment and give your methods good descriptive names
        //5) Parameters - These act as inputs and variables that exist for our method, like any other varaible these must be given 
        //A datatype. A method can have 0 to as many parameters as you wish (though if you have more than 10ish parameter, you might 
        //want to think about simplifying the method into smaller chunks
        public static int AddStarWarsCharacter(string[] characters)
        {
            if (characters.Contains("Yoda"))
            {
                //we'll find his index
                for(int i = 0; i < characters.Length; i++)
                {
                    string c = characters[i];
                    if(c == "Yoda")
                    {
                        return i;
                    }
                }
            }
                return -1;
           
        }

        public static string DeathStarCombat( Dictionary<string ,int> jediToPowers)
        {
            int highestPower = 0;
            string strongestJedi = "";
            //This is how you do it with a loop
            foreach(KeyValuePair<string, int> kvp in jediToPowers)
            {
                if(kvp.Value > highestPower)
                {
                    strongestJedi = kvp.Key;
                    highestPower = kvp.Value;
                }
            }

            return strongestJedi;
        }

        public static string DeathStarCombatLinq(Dictionary<string ,int> jediToPowers)
        {
            //Linq is a lot of guess and check 
            int highestPower = jediToPowers.Values.Max();

            //Where returns an ienumerable of all the matches
            string strongest = jediToPowers.Keys.Where(k => jediToPowers[k]==highestPower).First();
            return strongest;
        }

        public static List<string> ConvertPlanets(string[] planets)
        {
            //This is the C# way with its built in methods
            planets = planets.Reverse().ToArray();
            return planets.ToList();
        }

        public static List<string> ConvertPlanetsLongWay(string[] planets)
        {
           List<string> reversed = new List<string>();

            for(int i = planets.Length -1; i >= 0; i--)
            {
                reversed.Add(planets[i]);
            }

            return reversed;
        }


        public static double AverageDroids(List<int> droids)
        {
            double avg = droids.Where(d => d % 2 == 0).Average();
            return avg;
        }

        public static string TryToCatchDarthVader(string input)
        {
            try
            {
                int num = int.Parse(input);
                return "Darth Vader was captured!";
            }
            catch(FormatException ex)
            {
                return "Darth Vader got away!";
            }
        }
    }
}