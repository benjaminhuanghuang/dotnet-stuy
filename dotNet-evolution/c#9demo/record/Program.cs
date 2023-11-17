// See https://aka.ms/new-console-template for more information


Person p1 = new Person("ben", new string[3]);

Person p2 = p1 with { Name = "John" };


// Define the record
// default value
public record Person(string Name, string[] Friends, int Age = 50);


// inheritance
public record Teacher(string Name, string[] Friends, int Grade): Person(Name, Friends);
