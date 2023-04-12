
//What is an array? 
//An array is an object who's job is to store multiple items of the same type. 
//Like with any other variable you need to declare the datatype for an array variable 
//As well as putting [] after the data type
//Arrays have a set amount of spaces in them, you cannot create or remove spaces from an already existing array
//Arrays when empty at creation will have default values depening on the data type of the array
//1) number data types - default to 0 
//2) booleans - false 
//3) string - empty string == ""
//4) objects - null
int[] nums = new int[5];

//How are arrays organized? Arrays are indexed starting at 0. Each slot gets its own index. 
//[] [] [] [] []
//0  1  2  3  4

//Why do we count starting at 0? Someone made that decision in the 70s and most coding languages have follow suit since then. 
//The one exception is Python, which indexes starting at 1. 

//This is how you pull a single item out of an array, you give it an index and set it equal to variable
int num = nums[0];
int num2 = nums[2];

//This how you set a value in anray: 
nums[1] = 34;
nums[0] = 99;
nums[2] = 100;
nums[3] = 1992;


//This is how you fill up an array when creating it 
int[] nums2 = { 12, 119, 107, 59, 25, 90, 19 };

//Will this give us the contents of the array? 
Console.WriteLine(nums2);

//This works for small arrays, this will get too repititive for large arrays 
Console.WriteLine(nums2[0]);

Console.WriteLine("For Loop");

//Make sure you memorize this 
//You use this loop a lot and every language will have similar for loops 

//The .length returns the number of slots in the array
//If we add in extra times, .Length will shrink and grow
for(int i = 0; i < nums2.Length; i++)
{
    //This will loop through and print the entire array
    Console.WriteLine($"Index: {i}, Value: {nums2[i]}");
}


//lets print out the array to see the initial values 
int[] nums3 = new int[6];
Console.WriteLine("Empty Number array");
for(int i = 0; i < nums3.Length; i++)
{
    Console.WriteLine($"Index: {i}, Value: {nums3[i]}");
}

//You can make an array of any data type, includes classes you write yourself
string[] names = new string[5];
Console.WriteLine("Print empty string[]");
for(int i = 0; i < names.Length; i++)
{
    Console.WriteLine($"Index: {i}, Value: {names[i]}");
}
//Why did the programmer quit his job? He didn't get arrays. 