bool keepRunning = true;
int num = 0;

Console.WriteLine("While Loop is starting");
//If your loop goes infinite the first thing you should check is the end condition 
while(keepRunning == true)
{
    num++;
    Console.WriteLine(num);

    if (num > 10)
    {
        //keepRunning = false;
        break;
    }
}

Console.WriteLine("For Loop is starting");

//This is the most important loop, get comfortable with it, you use it the most often
for( int i =0; i < 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Foreach Loop is starting");

//This is an array, note the box brackets 
int[] nums = { 10, 32, 40, 49, 99, 10, 25 };

//This completely dodges the possibility of giving an array a bad index
//Foreach loops are only useable with arrays and collections 
//The foreach in every language will be a little different
foreach(int num2 in nums)
{
    if (num2 % 2 == 0)
    {
        Console.WriteLine(num2);
    }
    else
    {
        continue;
    }
}