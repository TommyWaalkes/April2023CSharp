namespace CompositionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPSPlayer user = new RPSPlayer(new UserThrow(), new UserNamer() );
            RPSPlayer opponent = new RPSPlayer(new RandomThrower(), new RandomNamer());

            RockPaperScissors userThrow = user.PickRPS(); 
            RockPaperScissors opponentThrow = opponent.PickRPS();

            Console.WriteLine(user.Name + " Throw: "+userThrow);
            Console.WriteLine(opponent.Name+ " Throw: " + opponentThrow);
        }
    }
}