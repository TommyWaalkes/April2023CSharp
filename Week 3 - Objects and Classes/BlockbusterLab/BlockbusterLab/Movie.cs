using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    public enum Genre
    {
        Drama,
        Comedy, 
        Horror, 
        Romance,
        Action
    }
    abstract class Movie
    {
        public string Title { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; } = new List<string>();
        public Genre Category { get; set; }

        //I'm putting params so instead of making a full string list, I can just feed scenes in directly via the contructor
        //If you're using params it must be the last parameter, so C# doesn't get confused
        public Movie(string title, int runtime, Genre category, params string[] scenes)
        {
            Title = title;
            Runtime = runtime;
            Scenes = scenes.ToList();
            Category = category;
        }

        public override string ToString()
        {
            string output = Title + "\n";
            output += Runtime + "\n";
            output += Category + "\n";

            return output;
        }

        public void PrintScenes()
        {
            for(int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine(i + " "+ Scenes[i]);
            }
        }

        public abstract void Play();
    }
}
