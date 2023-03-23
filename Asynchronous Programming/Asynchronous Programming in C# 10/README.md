# Asynchronous Programming in C# 10
By Filip Ekberg
https://app.pluralsight.com/library/courses/c-sharp-10-asynchronous-programming/table-of-contents
https://github.com/fekberg/c-sharp-asynchronous-programming


## Course Overview		

Best Practices
- Always use async and await together
- Use async and await all the way up the chain
- Always return a Task from an asynchronous method
- Never use async void unless it's an event handler or delegate
- Always await an asynchronous method to validate the operation
- Never block an asynchronous operation by calling Result or Wait()



## Getting Started with Asynchronous Programming in C# using Async and Await		46m 58s	
Executing long running synchronous operations on the thread will lock up the application

```
// Synchronous
private void Search_Click() {
    var client = new WebClient();
    var content = client. Down loadString(URL);
}

// Asynchronous
private async void Search_Click()
{
    var client = new HttpClient();
    var response = await client.GetAsync(URL);
    var content = await response.Content. ReadAsStringAsync() ;
}
``` 

Asynchronous Programming in NET
- Threading（Low-level）
- Background worker (Event-based asynchronous pattern)
- Task Parallel Library
- Async and await

## Using the Task Parallel Library for Asynchronous Programming		51m 4s	

Exploring Useful Methods in the Task Parallel Library		35m 4s	

Async & Await Advanced Topics		31m 25s	

Asynchronous Programming Advanced Topics		30m 50s	

Parallel Programming and Multithreading in C#		41m 12s	

Advanced Parallel Programming: Understanding Locking and Shared Variables		42m 42s	

Using Parallel LINQ (PLINQ)