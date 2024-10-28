
using ConsoleApp.Exstensions;
using ConsoleApp.ExtendDictionary;


Console.WriteLine("Exstensions examples:\n");
string str = "Hello world!";

Console.WriteLine($"Input string: {str}");

Console.WriteLine($"Inverse string: {str.Inverse()}");
Console.WriteLine($"Count letters 'l' in string: {str.CountLetter('l')}");


char[] arr = [.. str];

Console.WriteLine($"Input array: {arr.ToOutputString()}");

Console.WriteLine($"Count repeat value 'o': {arr.ValueRepeatCount('o')}");
Console.WriteLine($"Unique array: {arr.UniqueArray().ToOutputString()}");


Console.WriteLine("\n\n");

Console.WriteLine("Extended dictionary examples:\n");

ExtendedDictionary<string, int, int> ed = [];

ed.Add(new("Andrew", 1, 2));
ed.Add(new("London", 5, 4));

if (ed.Count > 0)
    Console.WriteLine($"Current dictionary count: {ed.Count}");

string key = "London";
if (ed.ContainsKey(key))
    Console.WriteLine($"Element with key: {key} have first value: {ed[key].FirstValue}, and second value: {ed[key].SecondValue}");