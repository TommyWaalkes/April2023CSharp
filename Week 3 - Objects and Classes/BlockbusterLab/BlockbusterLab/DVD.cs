using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string title, int runtime, Genre category, params string[] scenes) : base(title, runtime, category, scenes)
        {
        }

        public override void Play()
        {
            PrintScenes();
            
            int index = Validator.GetIntFromUser("Please select the index of the movie you'd like to watch");

            bool validIndex = Validator.WithinRange(index, Scenes);

            if (validIndex)
            {
                string scene = Scenes[index];
                Console.WriteLine("Playing Scene: " + scene);
            } else
            {
                Console.WriteLine($"Input index: {index} was not a valid");
                Console.WriteLine($"Please input an index from 0 to {Scenes.Count -1}");
                Console.WriteLine("Let's try again");
                Play();
            }
        }
    }
}
