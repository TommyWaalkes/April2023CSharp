namespace BlockbusterLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DVD d = new DVD("Star Wars", 123, Genre.Action, "Droids", "Death Star", "Cantina scene");
            //d.Play();
            //Console.WriteLine(d);

            //VHS v = new VHS("Alladin", 100, Genre.Drama, "Market Scene", "A whole new world", "They meet Genie");
            //v.Play();
            //v.Play();
            //v.Play();
            //v.Play();

            Blockbuster b = new Blockbuster();
            Movie selected = b.Checkout();
            selected.Play();
        }
    }
}