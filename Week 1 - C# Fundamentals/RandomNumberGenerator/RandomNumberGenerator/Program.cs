Random r = new Random();

for (int i = 0; i < 5; i++)
{
    int x = r.Next(1, 7);

    Console.WriteLine(x);
}
Console.WriteLine("_____________");
//Say I want my RNG to behave predictably 
//Usually for the purpose of testing something 
//This is where we feed a seed
Random r2 = new Random(5);
for (int i = 0;i< 5; i++)
{
    int y = r2.Next(1, 7);
    Console.WriteLine(y);
}