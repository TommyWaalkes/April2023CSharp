namespace ListsStudentDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //We need the using statement for collections anymore, BUT if you did, visual studio is good about telling you. 
            List<string> names = new List<string>();
            names.Add("Huey");
            names.Add("Louie");
            names.Add("Dewey");

            List<string> favoriteFoods = new List<string>();
            favoriteFoods.Add("Sushi");
            favoriteFoods.Add("Pasta");
            favoriteFoods.Add("Pizza");

            List<string> hometowns = new List<string>();
            hometowns.Add("Detroit");
            hometowns.Add("Los Angles");
            hometowns.Add("New York");

            for(int i = 1; i <= names.Count; i++)
            {
                Console.WriteLine(i + " " + names[i-1]);
            }

            Console.WriteLine("Please select a person you wish to learn about 1 to " + names.Count);
            int pick = int.Parse(Console.ReadLine()) - 1;

            string name = names[pick];

            Console.WriteLine($"What would you like to learn about {name}? home or favorite");
            string input = Console.ReadLine();

            if(input.ToLower().Trim() == "home")
            {
                Console.WriteLine($"{name}'s hometown is {hometowns[pick]}");
            }
            else
            {
                Console.WriteLine($"{name}'s favorite food is {favoriteFoods[pick]}");
            }

        }
    }
}