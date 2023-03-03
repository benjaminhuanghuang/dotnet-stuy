// See https://aka.ms/new-console-template for more information

using NullChecking.CSharp6;

var value = new Random().Next(10) > 5 ? new MySpecialClass("Test") : null;

if( value == null)
{
    Console.WriteLine("Value is null");
} else
{
    Console.WriteLine($"Value is {value}");
}

if(value?.Name == null)
{
    Console.WriteLine("Value is null or value.name is null");
}

// 
var test = value?? new MySpecialClass("Hello");
