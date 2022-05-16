// See https://aka.ms/new-console-template for more information
Console.Write("Enter first number: ");
string number1 = Console.ReadLine();
int x = int.Parse(number1);

Console.Write("Enter second number: ");
string number2 = Console.ReadLine();
int y = int.Parse(number2);

Console.Write("Enter third number: ");
string number3 = Console.ReadLine();
int z = int.Parse(number3);

int result1 = ((x + y)*z);
int result2 = ((x*y)+(y*z));


Console.WriteLine("(x+y)*z = " + result1);
Console.WriteLine("(x*y)+(y*z) = " + result2);