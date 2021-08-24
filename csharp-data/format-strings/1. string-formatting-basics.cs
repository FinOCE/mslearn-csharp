// Composite formatting
string first = "Hello";
string second = "World";
string result = string.Format("{0}, {1}!", first, second);
Console.WriteLine(result); // Hello World!

Console.WriteLine("{0} {0} {1}!", first, second); // Hello Hello World!



// String interpolation
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!"); // Hello World!



// Formatting currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})"); // Formats as local currency (e.g. $)



// Formatting numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units"); // Formats number to local (e.g. 123,456.78)
Console.WriteLine($"Measurement: {measurement:N4} units"); // Can specify number of digits as well



// Formatting percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}"); // Represent value as a percentage (at specify number of digits)