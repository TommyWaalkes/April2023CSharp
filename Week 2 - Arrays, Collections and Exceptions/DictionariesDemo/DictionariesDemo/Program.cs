namespace DictionariesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I usually like to name my dictionaries after my key and value
            //It's on the programmer to enforce and remember the meaning of the data in the dictionary 
            Dictionary<string, int> playersToNumbers = new Dictionary<string, int>();

            //Add in keys/values 
            playersToNumbers.Add("Babe Ruth", 39);
            playersToNumbers.Add("Joe Dimagio", 14);
            playersToNumbers.Add("Cal Ripken", 25);
            playersToNumbers.Add("Jackie Robinson", 11);
            playersToNumbers.Add("Jimmy Scrambles", 11);

            //Retrieve a player from a dictionary 
            //This syntax comes up often in .Net Apps
            int ruthsNum = playersToNumbers["Babe Ruth"];
            Console.WriteLine(ruthsNum);

            int jackieNum = playersToNumbers["Jackie Robinson"];
            Console.WriteLine(jackieNum);

            int jimmyNum = playersToNumbers["Jimmy Scrambles"];
            Console.WriteLine(jimmyNum);


            //Technically dictionaries are lists of Key-Value pair objects 
            //Were iterating through a list of objects 
            //The KeyValuePair gives us access to both the key and value, and is one of smoother of iterating through a Dictionary 
            //Dictionaries are NOT indexed 
            foreach(KeyValuePair<string, int> kvp in playersToNumbers)
            {
                Console.WriteLine("Key: "+ kvp.Key);
                Console.WriteLine("Value: "+ kvp.Value);
                Console.WriteLine();
            }

            List<string> keys = playersToNumbers.Keys.ToList();
            for (int i = 0; i < playersToNumbers.Count; i++)
            {
                string key = keys[i];
                int playerNum = playersToNumbers[key];
                playerNum++;
                playersToNumbers[key] = playerNum;
            }

            Console.WriteLine("All players numver should be increased by 1");
            foreach (KeyValuePair<string, int> kvp in playersToNumbers)
            {
                Console.WriteLine("Key: " + kvp.Key);
                Console.WriteLine("Value: " + kvp.Value);
                Console.WriteLine();
            }
        }
    }
}