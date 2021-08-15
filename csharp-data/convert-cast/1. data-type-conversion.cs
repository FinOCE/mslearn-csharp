int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result); // will output 24



int myInt = 3;
Console.WriteLine($"int: {myInt}"); // will output 3

decimal myDecimal = myInt;
Console.WRiteLine($"decimal: {myDecimal}"); // will output 3



decimal myDecimal = 3.13m;
Console.WriteLine($"decimal: {myDecimal}"); // will output 3.14

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}"); // will output 3



decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"decimal: {myDecimal}"); // will output 1.23456789
Console.WriteLine($"float: {myFloat}"); // will output 1.2345678



int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message); // will output 57



string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum); // will output 12



string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result); // will output 35



int value = (int)1.15m;
Console.WriteLine(value); // will output 1, casting truncated

int value2 = Convert.ToInt32(1.5m);
Console.WriteLine(value2); // will output 2, converting rounds up