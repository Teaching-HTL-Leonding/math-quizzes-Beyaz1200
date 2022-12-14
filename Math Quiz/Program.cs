Console.Clear();
string Operator = "0";
double operand1= 0;
double operand2 = 0;
double result = 0 ;

Console.Write("Chosse one the numbers: ");
operand1 = double.Parse(Console.ReadLine()!);

Console.Write("Chosse one the numbers: ");
operand2 = double.Parse(Console.ReadLine()!);

Console.Write("The result is: ");
result = double.Parse(Console.ReadLine()!);

if (operand1 + operand2 == result)
{
Operator = "+";
}

else if (operand1 - operand2 == result)
{
Operator = "-";
}

else if (operand2 - operand1 == result)
{
Operator = "-";
}

else if (operand2 * operand1 == result)
{
Operator = "*";
}

else if (operand2 / operand1 == result)
{
Operator = "/";
}

else if (operand1 / operand2 == result)
{
Operator = "/";
}

Console.Write($"The operarot is {Operator}");

