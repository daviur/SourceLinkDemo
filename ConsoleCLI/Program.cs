// See https://aka.ms/new-console-template for more information

using VerySmartLib;

var cal = new NumberCalculator();
Console.WriteLine(cal.CalculateFibonacci(10));

var msg = new MessageGenerator();
Console.WriteLine(msg.GetMessage());

Console.WriteLine(StaticApi.GetMessage());
Console.WriteLine(StaticApi.CalculateFibonacci(10));