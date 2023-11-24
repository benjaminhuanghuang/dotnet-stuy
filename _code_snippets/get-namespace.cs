/*
?? is the null-coalescing operator. that means “If the namespace of Program is null, then return None!; otherwise, return the name.
*/
string name = typeof(Program).Namespace ?? "None!";
Console.WriteLine($"Namespace: {name}");
