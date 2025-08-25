int number1;
int number2;
int quotient;
int remainder;

Console.WriteLine("Enter first number:");
number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number:");
number2 = Convert.ToInt32(Console.ReadLine());
quotient = number1 / number2;
remainder = number1 % number2;
Console.WriteLine($"The quotient of the numbers is {quotient}, their remainder is {remainder}.");
