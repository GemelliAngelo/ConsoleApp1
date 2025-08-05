using System.Collections;

string[] nomi = { "Angelo", "Simone", "Davide" };

foreach (string nome in nomi)
{
    Console.WriteLine(nome);
}

static float Somma(float num1,float num2)
{
    return num1 + num2;
}

float number1 = float.Parse(Console.ReadLine());

float number2 = float.Parse(Console.ReadLine());

Console.WriteLine(Somma(number1,number2));


int[][] myArray =
{
    new int[] {0,1,2,3},
    new int[] {4,5},
    new int[] {6,7,8},
};

for (int i = 0; i < myArray.Length; i++)
{
    for (int j = 0; j < myArray[i].Length; j++)
    {
        Console.WriteLine(myArray[i][j]);
    }
}

ArrayList test = new ArrayList() { 6, false, new int[] { 1, 2, 3 }, new int[][] { new int [] {1,2,3 }, new int[] {4,5,6} }, "Angelo" };

for(int i = 0; i < test.Count; i++)
{
    Console.WriteLine(test[i]);
}

List<int> test2 = new List<int>() { 1, 2, 3, 4, 5 };

foreach(var ints in test2)
{
    Console.WriteLine(ints);
}

Hashtable hashTest = new Hashtable()
{
    {"Lombardia","Milano" },
    {"Piemonte","Torino" },
    {"Emilia-Romagna","Bologna" },
};

hashTest["Marche"] = "Ancona";

hashTest.Add("Abruzzo", "L'Aquila");

hashTest.Remove("Abruzzo");

foreach (DictionaryEntry city in hashTest)
{
    Console.WriteLine($"{city.Key} ==> {city.Value}");
}

Dictionary<string, string> dictTest = new Dictionary<string, string>()
{
    {"Lombardia","Milano" },
    {"Piemonte","Torino" },
    {"Emilia-Romagna","Bologna" },
};

foreach (KeyValuePair<string,string> city in dictTest)
{
    Console.WriteLine($"{city.Key} => {city.Value}");
}

Stack<int> stackTest = new Stack<int>();

stackTest.Push(1);
stackTest.Push(2);
stackTest.Push(5);
stackTest.Push(10);
stackTest.Push(20);
stackTest.Push(50);
stackTest.Push(100);

Console.WriteLine(stackTest.Peek());

stackTest.Pop();

foreach (int item in stackTest)
{
    Console.WriteLine(item);
}

stackTest.Clear();

Console.WriteLine(stackTest.TryPeek(out int result));
Console.WriteLine(stackTest.TryPop(out int res));

Console.Read();
