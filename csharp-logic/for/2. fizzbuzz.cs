for (int i = 1; i <= 100; i++)
{
    string text = i.ToString();

    if (i % 3 == 0 || i % 5 == 0) text += " - ";
    if (i % 3 == 0) text += "Fizz";
    if (i % 5 == 0) text += "Buzz";

    Console.WriteLine(text);
}