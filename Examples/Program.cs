namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Es a

            int sum = 0;

            List<int> nums = new([new Random().Next(50), new Random().Next(100), new Random().Next(100), new Random().Next(100), new Random().Next(100),]);

            for(int i=0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
                sum += nums[i];
            }
            Console.WriteLine($"La Somma è {sum}");

            #endregion

            #region Es b

            int sum2 = 0;

            List<int> nums2 = new([Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()),]);

            for(int i = 0; i < nums2.Count; i++)
            {
                sum2 += nums2[i];
            }

            Console.WriteLine($"La Somma è {sum2}");

            #endregion

        }
    }
}
