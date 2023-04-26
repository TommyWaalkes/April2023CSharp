namespace ArrayExercise
{
    public class Program { 
        public static void Main()
        {
            int[] nums = { 12, 30, 45, 67, 99 };
            int result = PickNumsFromArray(nums);
            Console.WriteLine(result);
            int[] num2 = { 90, 46, 33, 41 };
            int[] combined = CombineArrays(nums, num2);

            for(int i = 0; i < combined.Length; i++)
            {
                Console.WriteLine(i+" "+combined[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Print Combined Array in Reverse");
            PrintInReverse(combined);

            PrintArray( nums);
        }

        public static int PickNumsFromArray(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(i +" "+nums[i]);
            }

            Console.WriteLine("Please select the first index");
            int index1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please select the second index");
            int index2 = int.Parse(Console.ReadLine());

            if(index1 == index2)
            {
                Console.WriteLine("Please select different indexes");
                Console.WriteLine("Let's try again");
                return PickNumsFromArray(nums);
            }
            else if(index1 >= nums.Length || index1 < 0 || index2 >=nums.Length || index2 < 0)
            {
                Console.WriteLine("One of the indexes is out of range: 0 to "+ (nums.Length -1) );
                Console.WriteLine("Lets try again");
                return PickNumsFromArray(nums);
            }
            else
            {
                int total = nums[index1] + nums[index2];
                return total;
            }
        }

        public static int[] CombineArrays(int[] nums1, int[] nums2)
        {
            int[] output = new int[nums1.Length + nums2.Length];

            for(int i = 0; i < nums1.Length;i++)
            {
                output[i] = nums1[i];
            }

            int j = 0;

            for(int i = nums1.Length; i < nums2.Length + nums1.Length; i++,j++)
            {
                output[i] = nums2[j];
            }

            return output;
        }

        public static void PrintInReverse(int[] nums)
        {
            for(int i = nums.Length -1; i>=0; i--)
            {
                Console.WriteLine(nums[i]);
            }
        }

        //Object is the grandfather to all types in C# 
        public static void PrintArray<t>(t[] inputs)
        {
            for(int i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine(inputs[i]);
            }
        }
    }
}