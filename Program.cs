

string firstString = Console.ReadLine();
string symbol = Console.ReadLine();
string secondString = Console.ReadLine();
int firsNumber = Convert.ToInt32(firstString);
int secondNumber = Convert.ToInt32(secondString);
if(symbol == "+") System.Console.WriteLine(firsNumber + secondNumber);
else if(symbol == "-") Console.WriteLine(firsNumber - secondNumber);
else if(symbol == "*") System.Console.WriteLine(firsNumber * secondNumber);
else if(symbol == "/") System.Console.WriteLine(firsNumber / secondNumber);