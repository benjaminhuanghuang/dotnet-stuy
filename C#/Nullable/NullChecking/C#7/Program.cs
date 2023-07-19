// See https://aka.ms/new-console-template for more information

using NullChecking.CSharp7;

var value = new Random().Next(10) > 5 ? new MySpecialClass("Test") : null;


if (value is null)
{
    Console.WriteLine("Value is null");
}

/*
 * "is null" is safer than "==null" when user override the operator 
 * 
 * In IL code ==null is translated to a call to function op_Equality
 * 
 * is null is translated to ceq which compare value
 */

if (!(value is null))
{
    Console.WriteLine($"Value is {value}");
}

if (value?.Name == null)
{
     Console.WriteLine("Value is null or value.name is null");
}


_ = value ?? throw new ArgumentNullException(nameof(value));
// equals to 
if (value is null)
{
    throw new ArgumentNullException(nameof(value));
}