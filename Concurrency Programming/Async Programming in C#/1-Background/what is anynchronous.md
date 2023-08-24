
## Synchronous
```
class Program
{
    static void Main() {
        PrintSum(1, 2, 3);
        PrintSum(10, 20, 20);
        PrintSum(100, 200, 300);
    }

    static void PrintSum(int a, int b, int c) {
        Console.WriteLine("Sum: {0}", a + b + c);
    }
}
```


## Asynchronous 
- More than one part of the program is running
- One stack per thread
- Scheduling and thread priority
