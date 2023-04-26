namespace MovieLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie("Star Wars", MovieGenre.scifi));
            movies.Add(new Movie("Finding Nemo", MovieGenre.animated));
            movies.Add(new Movie("The Room", MovieGenre.drama));
            
            //If you need all the values in an enum this is how you do it
            List<MovieGenre> genres = Enum.GetValues(typeof(MovieGenre)).Cast<MovieGenre>().ToList();
            for(int i = 0; i < genres.Count; i++)
            {
                Console.WriteLine(i + " " + genres[i]);
            }
            Console.WriteLine("Please input an index or the name of the genre you wish to search for");

            string response = Console.ReadLine();
            int index;
            MovieGenre input2 = MovieGenre.invalid;

            try
            {
                index = int.Parse(response);
                input2 = genres[index];
            }
            catch(FormatException e)
            {
                Enum.TryParse(response, out input2);
            }

            //MovieGenre input = Enum.Parse( typeof(MovieGenre), Console.ReadLine());
           
            //Console.WriteLine(input);
            if (input2 == MovieGenre.invalid)
            {
                Console.WriteLine("That was not a valid input, please try again");
            }
            else
            {
                Console.WriteLine("Movies that are of type: " + input2);
                for (int i = 0; i < movies.Count; i++)
                {
                    //Check if the movie genre matches the input genre 
                    Movie m = movies[i];
                    if (m.Category == input2)
                    {
                        Console.WriteLine(m.Title);
                    }
                }
            }
        }
    }
}