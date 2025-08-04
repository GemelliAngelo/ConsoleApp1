using System.Collections;

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


int[][] myArray =
{
    new int[] {0,1,2,3},
    new int[] {4,5,6},
    new int[] {7,8,9,10,11,12},
    new int[] {13},
};

for (int i = 0; i < myArray.Length; i++)
{
    for (int j = 0; j < myArray[i].Length; j++)
    {
        Console.WriteLine(myArray[i][j]);
    }
}

ArrayList test = new ArrayList() { "a", 6, false, new int[] { 1, 2, 3, 4 }, new int[][] { new int [] {1,2,3 },new int[] {4,5,6} }, "Angelo" };

for(int i = 0; i < test.Count; i++)
{
    Console.WriteLine(test[i]);
}

List<int> test2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach(var ints in test2)
{
    Console.WriteLine(ints);
}


Console.Read();
