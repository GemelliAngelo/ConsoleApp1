using System.Text;

namespace FirstApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Concatenazioni possibili
            string? myVal = Console.ReadLine();
            Console.WriteLine("My value is: " + myVal);
            Console.WriteLine(new string(myVal.Concat(" QWERTY").ToArray()));
            Console.WriteLine(string.Concat(myVal, " Angelo"));
            Console.WriteLine($"{myVal} Angelo");

            #region StringBuilder

            // Dichiarazione vecchia
            StringBuilder builder = new StringBuilder();
            // Dichiarazione nuova
            StringBuilder builder2 = new();

            builder.AppendLine("Hello");
            builder.Append("John");
            builder.Append(" Doe");
            builder.Append(Environment.NewLine);
            builder.AppendLine("Ciao!");

            Console.WriteLine(builder.ToString());

            #endregion

            var name = Console.ReadLine();
            var surname = Console.ReadLine();
            string emailTemplate = string.Format("Hello, {0} {1}, this is a test!", name, surname);
            Console.WriteLine(emailTemplate);

            DateTime d = DateTime.Now;
            Console.WriteLine(d);

            double? price = double.Parse(Console.ReadLine());
            Console.WriteLine(price);

            Dictionary<string, List<string>> books = new();
            books.Add("Antonio", ["book1", "book2"]);
            books.Add("Mario", ["book3,book4"]);

            Dictionary<string, List<string>> books_alt = new()
            {
                { "Antonio",["book1","book2"] },
                { "Mario",["book3","book4"] }
            };

            books.TryGetValue("Antonio", out List<string>? antonioBooks);
            Console.WriteLine(antonioBooks![1]);

            List<string>? results = books.GetValueOrDefault("Antonio");
            Console.WriteLine(results);

            KeyValuePair<string, List<string>> bookKvp = new("Joe", ["Harry Potter", "Star Wars"]);
            Console.WriteLine($"{bookKvp.Key} | {string.Join(", ", bookKvp.Value)}");

            int num = default;

            switch(num)
            {
                case 0:
                    Console.WriteLine($"Is {num}");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Is 1 or 2");
                    break;
                case 100:
                    Console.WriteLine("is 100");
                    break;
                default:
                    Console.WriteLine("No case found");
                    break;
            }

            Console.WriteLine("Hello, World!");
            Console.Read();
        }
    }
}
