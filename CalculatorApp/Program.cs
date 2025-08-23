using System;

public class Calculator
{
    public int Add(int a, int b) => a + b;
    public int Prod(int a, int b) => a * b;
    public int Sub(int a, int b) => a - b;
    public int Div(int a, int b) => a / b;
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Sub(1, 2));
        Console.WriteLine(calculator.Prod(1, 2));
        Console.WriteLine(calculator.Div(1, 2));
    }
}
