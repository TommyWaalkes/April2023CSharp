namespace ParamsKeyword
{
    public class Program
    {
        public static void Main()
        {
            //I don't have make a whole a array any time I use this method 
            //I can feed in as many literals as I want
            int result = SumNumbers(90, 8, 2); 
            Console.WriteLine(result);

            int[] nums = { 10, 20, 30 };
            int result2 = SumNumbers(nums);
            Console.WriteLine(result2);
        }

        //Say I want to pass an array or multiple values to a method 
        //This is where I can use the params keyword

        //When I call the method, I can put in as many nums as I want in comma separated listing (not a C# list a list of numbers with commas) 
        //1) All input numbers get automatically put into an array 
        //2) if you decide to use params, it must be the last parameter of a method to prevent ambiguity
        //3) all input literals must match the data type of the params array. 
        public static int SumNumbers( params int[] nums)
        {
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;
            }

            return sum;
        }

    }
}