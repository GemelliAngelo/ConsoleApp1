using ConsoleApp1;
using System.Collections;

// Array di nomi e stampa di ciascun nome
string[] names = { "Angelo", "Simone", "Davide" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

// Funzione per sommare due numeri float
static float Sum(float num1, float num2)
{
    return num1 + num2;
}

// Lettura di due numeri float da input e stampa della loro somma
float number1 = float.Parse(Console.ReadLine());
float number2 = float.Parse(Console.ReadLine());

Console.WriteLine(Sum(number1, number2));

// Dichiarazione e stampa di un array di array (matrice irregolare)
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

// Utilizzo di ArrayList con elementi di tipi diversi
ArrayList test = new ArrayList() { 6, false, new int[] { 1, 2, 3 }, new int[][] { new int [] {1,2,3 }, new int[] {4,5,6} }, "Angelo" };

for(int i = 0; i < test.Count; i++)
{
    Console.WriteLine(test[i]);
}

// Utilizzo di List<int> e stampa degli elementi
List<int> test2 = new List<int>() { 1, 2, 3, 4, 5 };

foreach(var ints in test2)
{
    Console.WriteLine(ints);
}

// Creazione e manipolazione di una Hashtable
Hashtable hashTest = new Hashtable()
{
    {"Lombardia","Milano" },
    {"Piemonte","Torino" },
    {"Emilia-Romagna","Bologna" },
};

// Aggiunta, modifica e rimozione di elementi nella Hashtable
hashTest["Marche"] = "Ancona";
hashTest.Add("Abruzzo", "L'Aquila");
hashTest.Remove("Abruzzo");

// Stampa delle coppie chiave/valore della Hashtable
foreach (DictionaryEntry city in hashTest)
{
    Console.WriteLine($"{city.Key} ==> {city.Value}");
}

// Creazione e stampa di un Dictionary<string, string>
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

// Utilizzo di Stack<int> e operazioni principali
Stack<int> stackTest = new Stack<int>();

stackTest.Push(1);
stackTest.Push(2);
stackTest.Push(5);
stackTest.Push(10);
stackTest.Push(20);
stackTest.Push(50);
stackTest.Push(100);

// Visualizza l'elemento in cima allo stack
Console.WriteLine(stackTest.Peek());

// Rimuove l'elemento in cima allo stack
stackTest.Pop();

// Stampa di tutti gli elementi dello stack
foreach (int item in stackTest)
{
    Console.WriteLine(item);
}

// Svuota lo stack
stackTest.Clear();

// Prova a visualizzare e rimuovere elementi dallo stack vuoto
Console.WriteLine(stackTest.TryPeek(out int result));
Console.WriteLine(stackTest.TryPop(out int res));

// Utilizzo di Queue<string> e operazioni principali
Queue<string> queueTest = new Queue<string>();

queueTest.Enqueue("Angelo");
queueTest.Enqueue("Simone");
queueTest.Enqueue("Davide");
queueTest.Enqueue("Luca");
queueTest.Enqueue("Qwerty");

// Visualizza l'elemento in fondo alla queue
Console.WriteLine(queueTest.Peek());

// Stampa di tutti gli elementi della queue
while (queueTest.Count() > 0) Console.WriteLine(queueTest.Dequeue());

Person person1 = new Person("Angelo","Gemelli",23);

Console.WriteLine($"{person1.GetName()} {person1.GetSurname()},{person1.GetAge()}");

// Attende input per terminare il programma
Console.Read();
