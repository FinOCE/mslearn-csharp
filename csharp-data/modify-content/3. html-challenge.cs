// Predefined variables
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Format quantity
const string openSpan = "<span>";
const string closeSpan = "</span>";
int openSpanIndex = input.IndexOf(openSpan) + openSpan.Length;
int spanContentLength = input.IndexOf(closeSpan) - openSpanIndex;

quantity = "Quantity: " + input
    .Substring(openSpanIndex, spanContentLength);

// Format output
const string openDiv = "<div>";
const string closeDiv = "</div>";
int openDivIndex = input.IndexOf(openDiv) + openDiv.Length;
int divContentLength = input.IndexOf(closeDiv) - openDivIndex;

output = "Output: " + input
    .Substring(openDivIndex, divContentLength)
    .Replace("&trade;", "&reg;");

// Write to console
Console.WriteLine(quantity);
Console.WriteLine(output);