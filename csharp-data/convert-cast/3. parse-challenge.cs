string[] values = { "12.3", "45", "ABC", "11", "DEF" };

string message = "";
decimal total = 0m;

foreach (string value in values)
{
    decimal result;
    if (decimal.TryParse(value, out result))
    {
        total += result;
    }
    else
    {
        message += result;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");