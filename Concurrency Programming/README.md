


Best Practices
- Always use async and await together
- Use async and await all the way up the chain
- Always return a Task from an asynchronous method
- Never use async void unless it's an event handler or delegate
- Always await an asynchronous method to validate the operation
- Never block an asynchronous operation by calling Result or Wait()

Usage
- Load data without locking the user interface

