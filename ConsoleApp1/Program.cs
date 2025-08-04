string[] nomi = { "Angelo", "Simone", "Davide" };

foreach (string nome in nomi)
{
Console.WriteLine(nome);
}

static int Somma(int num1,int num2)
{
    return num1 + num2;
}

int number1 = int.Parse(Console.ReadLine());

int number2 = int.Parse(Console.ReadLine());

Console.WriteLine(Somma(number1,number2));

Console.Read();
