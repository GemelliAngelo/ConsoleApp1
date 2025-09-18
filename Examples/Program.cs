namespace Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Es a
            // Dichiaro la somma
            int sum = 0;
            // Dichiaro la lista di numeri
            List<int> nums = new();
            // Riempio la lista con un un numero casuale di numeri casuali
            for(int i = 0; i < new Random().Next(2,10); i++)
            {
                nums.Add(new Random().Next(100));
            }
            // Ciclo e sommo ogni elemento della lista
            for(int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums[i]);
                sum += nums[i];
            }
            // Stampo la lista
            Console.WriteLine($"La Somma è {sum}");

            #endregion

            #region Es b

            int sum2 = 0;
            // Genero la lista con elementi inseriti via prompt convertiti in int
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
