using Examples.Classes;

namespace CarsExercize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
           Concessionaria console app:
            1. La nostra app chiede se stampare l'elenco delle auto o inserire.
            2. Come secondo step la nostra app deve chiedere quante auto vogliamo inserire nella concessionaria.
            3. La nostra app deve chiedere il nome, modello, colore e anno di fabbricazione in console per poi inserire la auto in una lista.
            4. Una volta inserite le auto stampiamo a video l'elenco delle auto (potete utilizzare il metodo ToString) 
        */

            List<Car> cars = new()
            {
                new("ford", "fiesta", "grey", Convert.ToDateTime("2012-01-01")),
                new("seat", "ibiza", "white", Convert.ToDateTime("2011-01-01")),
                new("citroen", "c3", "red", Convert.ToDateTime("2014-01-01"))
            };

            Console.WriteLine("Digita 1 se vuoi vedere le auto o digita 2 per inserirne una nuova?");

            string input = Console.ReadLine();

            while (input != "1" && input != "2")
            {
                Console.WriteLine("Input non valido. Riprova");
                input = Console.ReadLine();
            }

            if (input == "1")
            {
                foreach (var car in cars)
                {
                    Console.WriteLine($"nome: {car.name} - modello: {car.model} - colore: {car.color} - anno: {car.yearOfProduction:yyyy}");
                }
            }else
            {
                Console.WriteLine("Quante auto vuoi inserire?");

                int num = Convert.ToInt32(Console.ReadLine());
                
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Inserisci il nome");
                    string newCar_name = Console.ReadLine();

                    Console.WriteLine("Inserisci il modello");
                    string newCar_model = Console.ReadLine();

                    Console.WriteLine("Inserisci il colore");
                    string newCar_color = Console.ReadLine();

                    Console.WriteLine("Inserisci l'anno");
                    DateTime newCar_year = Convert.ToDateTime(Console.ReadLine());

                    Car newCar = new(newCar_name, newCar_model, newCar_color, newCar_year);

                    cars.Add(newCar);

                }
                    foreach (var car in cars)
                    {
                        Console.WriteLine($"nome: {car.name} - modello: {car.model} - colore: {car.color} - anno: {car.yearOfProduction}");
                    }
            }

        }
    }
}
