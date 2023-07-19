// See https://aka.ms/new-console-template for more information

using NullChecking.CSharp8;

var value = new Random().Next(10) > 5 ? new MySpecialClass("Test") : null;


if (value is { }) 
{
    Console.WriteLine($"Value is not null, value is {value.Name}");
}


// set value if value is null 
value ??= new MySpecialClass("Test");




