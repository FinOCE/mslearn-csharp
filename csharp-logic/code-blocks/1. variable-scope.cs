bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
// Console.WriteLine($"outside of code block: {value}"); // Will not work because outside of code block



bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
// Console.WriteLine($"outside of code block: {value}"); // Will not work because potentially not assigned



bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}
Console.WriteLine($"outside of code block: {value}");