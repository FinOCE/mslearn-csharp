// My solution
string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');
string pangramReversed = "";

foreach (string word in words)
{
    char[] letters = word.ToCharArray();
    Array.Reverse(letters);
    pangramReversed += $" {new string(letters)}";
}

Console.WriteLine(pangramReversed);



// Example solution
string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);