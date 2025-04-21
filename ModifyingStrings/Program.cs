
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openIndex = input.IndexOf(openSpan);
openIndex += 6;
int closeIndex = input.IndexOf(closeSpan);
int length = closeIndex - openIndex;

quantity = $"Quantity: {input.Substring(openIndex, length)}";

const string openDiv = "<div>";
const string closeDiv = "</div>";

openIndex = input.IndexOf(openDiv);
openIndex += 5;
closeIndex = input.IndexOf(closeDiv);
length = closeIndex - openIndex;

output = $"Output: {input.Substring(openIndex, length)}";
output = output.Replace("&trade", "&reg");


Console.WriteLine(quantity);
Console.WriteLine(output);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";
// char[] openSymbols = {'[', '{', '('};

// int closingPosition = 0;

// while(true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if(openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition,1);

//     char matchingSymbol = ' ';

//     switch(currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

// }



// string message = "Help (find) the {opening symboles}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '('};
// int startPosition = 5;

// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");

// string message = "Hello, world!";
// char[] charsToFind = {'a', 'e', 'i'};

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

// string message = "(What if) there are (more than) one (set of parentheses)?";
// while(true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     message = message.Substring(closingPosition + 1);
//}

// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");


// string message = "What is the value <span> between the tages</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));



// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf("(");
// int closingPosition = message.IndexOf(")");

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// openingPosition += 1;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));