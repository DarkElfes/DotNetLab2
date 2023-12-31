using ConsoleApp.Classes;
using ConsoleApp.Classes.Extenstions;

// Review string extensions
Console.WriteLine("Review string extensions:");

string str = "Hello, World!";
Console.WriteLine($"Iverse string '{str}' = {str.Inverse()}");
Console.WriteLine($"Count word 'l' in '{str}' = {str.WordCount('l')}");

// Review one dimension array extensions
Console.WriteLine("\n\nReview one dimension array extensions:");

string[] usersName = { "Alica", "Dima", "Sasha", "Anna", "Alica" };
Console.WriteLine("Count of 'Alica' name in array: " + usersName.ValueCount("Alica"));

User[] users =
{
    new User{Name = "Alica", Email = "alica@gmail.com"},
    new User{Name = "Dima", Email = "dima@gmail.com"},
    new User{Name = "Alica", Email = "alica@gmail.com"},
    new User{Name = "Alica", Email = "alica@gmail.com"},
};

Console.WriteLine("Count of 'Alica' users in array: " + users.ValueCount(new User { Name = "Alica", Email = "alica@gmail.com" }));
Console.WriteLine("Unique array: \n" + string.Join<User>('\n', users.GetUniqueArray()));


//Review extended dictionary
Console.WriteLine("\n\nReview extended dictionary: ");

User Alica = new() { Name = "Alica", Email = "alica@gmail.com" };
User Dima = new() { Name = "Dima", Email = "dima@gmail.com" };
User Ivan = new() { Name = "Ivan", Email = "ivan@gmail.com" };

ExtendedDictionary<User, int, string> dictionary = new() {
    new(Dima, 23, "Kiev"),
    new(Ivan, 13, "Zhytomyr"),
};

dictionary.Add(new(Alica, 18, "London"));

dictionary.Remove(Dima);

Console.WriteLine(dictionary.Exist(Dima));
Console.WriteLine(dictionary.Exist(Alica));
Console.WriteLine(dictionary.Exist(13, "Zhytomyr"));

dictionary[Dima] = new(Dima, 23, "Kiev");
Console.WriteLine(dictionary[Alica]);


Console.WriteLine("\nAll user:");
foreach (var obj in dictionary)
    Console.WriteLine(obj);
