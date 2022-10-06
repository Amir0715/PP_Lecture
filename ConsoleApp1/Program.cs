// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

var dom = new House();
var dom2 = new House();
var dom3 = new House();

Book warAndPeace = new Book(150, "Толстой", "Война и мир", "Утория", "СБП");


warAndPeace.Title = "Война и мир";
warAndPeace.Genre = "Утопия";
warAndPeace.PageCount = 200;
warAndPeace.SetDescription("asdasd");
warAndPeace.Description = "asdasdaqwe";
warAndPeace.internalFloat = 10.23f;
var pageCount = warAndPeace.GetPageCount();

Console.WriteLine(pageCount);
Console.WriteLine(warAndPeace.Title);
Console.WriteLine(warAndPeace.Genre);
Console.WriteLine(warAndPeace.PageCount);
Console.WriteLine(warAndPeace.Description);
Console.WriteLine();

var list = new List<int>();
list.Add(2);
list.Add(3);
list.Add(2);
list.Add(4);

for (var i = 0; i < list.Count; i++)
{
    var number = list[i];
}
foreach (var i in list)
{
    Console.WriteLine(i);
}

var dictionary = new Dictionary<int, string>();
dictionary.Add(1, "One");
dictionary.Add(90, "90");
dictionary.Add(-120, "-120");

Console.WriteLine(dictionary[1]);

var isHasKey = dictionary.ContainsKey(-1);
if (isHasKey)
{
    Console.WriteLine(dictionary[-1]);
}

var value = "";
if (dictionary.TryGetValue(-1, out value))
{
    Console.WriteLine(value);
}

var x = 0;
warAndPeace.Increment(ref x);
Console.WriteLine(x);


static void SetDesciption(Book book)
{
    book.Author = "AShdas";
}

Console.WriteLine(warAndPeace.Author);
SetDesciption(warAndPeace);
Console.WriteLine(warAndPeace.Author);

warAndPeace.Sum(10, 20, out var result);
Console.WriteLine(result);