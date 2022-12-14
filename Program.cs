Console.Clear();

int start=  0;
int end = 0;
int counter = 0;

string fizz = "Fizz";
string buzz = "Buzz";

Console.Write("Enter start value from 1: ");
start = int.Parse(Console.ReadLine()!);

Console.Write($"Enter the end value {start + 1}: ");
end = int.Parse(Console.ReadLine()!);

Console.WriteLine("\n");    

for (int i = 0; i < 100 ; i++)
{
    Console.Write("*");
}
Console.WriteLine("");


while (start <= end)
{
    counter++;
    if (start % 3 == 0 && start % 5 != 0)
    {
        Console.Write($"   {fizz}");
    }
    else if (start % 5 == 0 && start % 3 != 0)
    {
        Console.Write($"   {buzz}");
    }
    else if (start % 3 == 0 && start % 5 == 0)
    {
        Console.Write($"   {fizz}{buzz}");
    }
    else
    {
        Console.Write($"{start}");
    }

    if (start < end)
    {
        Console.Write(",");
    }
    if (counter % 10 == 0 && counter != 0)
    {
        Console.WriteLine();
    }
    
    start++;
    
}

Console.WriteLine("");

for (int i = 0; i < 100 ; i++)
{
    Console.Write("-");
}

