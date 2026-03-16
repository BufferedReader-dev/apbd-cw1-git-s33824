// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Pierwsza modyfikacja");
Console.WriteLine("Druga modyfikacja");
if (true)
{
    Console.WriteLine("Trzecia modyfikacja");
}

if (!false)
{
    Console.WriteLine("Czwarta modyfikacja");
}


Double CalculateAverage(int[] values)
{ //I have change double type to Double and added this comment
  return (double)values.Sum() / values.Length;  
}

int CalculateMax(int[] values)
{
    return values.Max();
}

int CalculateMin(int[] values)
{   Console.WriteLine("First commit");
    Console.WriteLine("Second commit");
    Console.WriteLine("Third commit");
    Console.WriteLine("Commit for main branch");

    return values.Min();
}