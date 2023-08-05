using System.Globalization;

namespace CalendarTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JulianCalendar jc = new JulianCalendar();
            DateTime dt = new DateTime(1753 , 1 , 1);
            Console.WriteLine(dt);

            DateTime.FromOADate(dt.Ticks + 2415018.5);

            Console.WriteLine(dt);
        }
    }
}