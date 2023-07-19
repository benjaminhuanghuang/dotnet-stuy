// See https://aka.ms/new-console-template for more information

using NullChecking.Sharp9;

var value = new Random().Next(10) > 5 ? new MySpecialClass("Test") : null;


if (value is null)
{
    Console.WriteLine("Value is null");
}

if (value is not null)
{

}