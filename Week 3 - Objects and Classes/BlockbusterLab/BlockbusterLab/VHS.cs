using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string title, int runtime, Genre category, params string[] scenes) : base(title, runtime, category, scenes)
        {
        }

        public override void Play()
        {
            if (CurrentTime < Scenes.Count)
            {
                bool validIndex = Validator.WithinRange(CurrentTime, Scenes);
                if (validIndex)
                {
                    string scene = Scenes[CurrentTime];
                    Console.WriteLine(scene);
                    CurrentTime++;
                }
            }
            else
            {
                Rewind();
            }
        }

        public void Rewind()
        {
            Console.WriteLine("Rewinding back to the start of the movie");
            CurrentTime = 0;
        }
    }
}
