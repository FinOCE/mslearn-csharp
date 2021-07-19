// https://docs.microsoft.com/en-us/learn/modules/csharp-basic-formatting

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello \"World\"!");
Console.WriteLine("c:\\source\\repos");

Console.WriteLine("Generating invoice for customer \"ABC Corp\"... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

Console.WriteLine(@"    c:\source\repos
    (this is where your code goes");

Console.Write(@"c:\invoices");

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

string firstName = "Bob";
string message = "hello " + firstName;
Console.WriteLine(message);

string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

Console.WriteLine(greeting + " " + firstName + "!");

string message = $"{greeting} {firstName}";

string firstName = "Bob";
Console.WriteLine($"Hello {firstName}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

// The challenge...
string projectName = "ACME";

string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output\n\t\t{englishLocation}");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}");