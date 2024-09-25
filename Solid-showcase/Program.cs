// See https://aka.ms/new-console-template for more information

// OPEN CLOSED PRINCIPLE 

using Solid_showcase.Solid._2_Open_Closed;
using Calculator = Solid_showcase.Solid._2_Open_Closed.BadExample.Calculator;

IOperation addition = new Addition();
Calculator calculator = new Calculator(addition);
int result = calculator.Calculate(5, 3);
Console.WriteLine($"Addition: {result}");

IOperation multiplication = new Multiplication();
calculator = new Calculator(multiplication);
result = calculator.Calculate(5, 3);
Console.WriteLine($"Multiplikation: {result}");