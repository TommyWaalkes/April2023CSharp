Console.WriteLine("Welcome to the coin flip challenge");
Console.WriteLine("What is your name?");

//Names are simply strings no need for parsing
string name = Console.ReadLine();

Console.WriteLine($"Well {name}, would you like to do the coin flip challenge? y/n");
string response = Console.ReadLine();

if (response == "y")
{
    //Do the challenge
    int correctGuesses = 0; 

    for(int i =0;i <5; i++)
    {
        Random r = new Random();
        
        //The minimum number is inclusive
        //The maximum number is exclusive 
        //Most random number generators, both numbers are inclusive, not in C# 
        int roll = r.Next(0,2);
        string result;
        if(roll == 0)
        {
            result = "heads";
        }
        else
        {
            result = "tails";
        }

        Console.WriteLine($"Round number {i + 1}");
        Console.WriteLine("Guess the filp input heads or tails");
        string guess = Console.ReadLine();

        if (guess == result) {
            Console.WriteLine("Correct!");
            correctGuesses++;
        }
        else
        {
            Console.WriteLine("Incorrect!");
        }

    }
        Console.WriteLine($"you got {correctGuesses} out of 5 corrects flips");
}
else
{
    Console.WriteLine($"You are a coward {name}!");
}
