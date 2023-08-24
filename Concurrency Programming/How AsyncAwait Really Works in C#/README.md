# How Async/Await Really Works in C#
March 16th, 2023

https://devblogs.microsoft.com/dotnet/how-async-await-really-works/

## Synchronous vs. async-await function
synchronous method: caller will not be able to do anything else `until` this whole operation completes and control is returned back to the caller:
```
// Synchronously copy all data from source to destination.
public void CopyStreamToStream(Stream source, Stream destination)
{
    var buffer = new byte[0x1000];
    int numRead;
    while ((numRead = source.Read(buffer, 0, buffer.Length)) != 0)
    {
        destination.Write(buffer, 0, numRead);
    }
}
```

async-await function: control is expected to be returned back to its caller very quickly and possibly before the work associated with the whole operation has completed:
```
// Asynchronously copy all data from source to destination.
public async Task CopyStreamToStreamAsync(Stream source, Stream destination)
{
    var buffer = new byte[0x1000];
    int numRead;
    while ((numRead = await source.ReadAsync(buffer, 0, buffer.Length)) != 0)
    {
        await destination.WriteAsync(buffer, 0, numRead);
    }
}
```

The magic is performed by the C# compiler and core libraries.


## APM(Asynchronous Programming Model or IAsyncResult) pattern in .NET Framework 1.0 
There are two corresponding methods as part of the pattern: BeginXXX() and EndXXX():
```
class Handler
{
    public int DoStuff(string arg);

    /*
        BeginXXX would accept all of the same parameters as the synchronous version, 
        but in addition it would also accept an AsyncCallback delegate and an opaque state object.
        one or both of which could be null.

        The Begin method would also construct an instance of a type that implemented IAsyncResult, using the optional state to populate that IAsyncResult‘s AsyncState property.

        This IAsyncResult instance would be passed to the AsyncCallback when it was eventually invoked. 

        When ready to consume the results of the operation, a caller would then pass that IAsyncResult instance to the End method.
    */
    public IAsyncResult BeginDoStuff(string arg, AsyncCallback? callback, object? state);

    /*
        The Begin method was responsible for initiating the asynchronous operation, and if provided with a callback, it was also responsible for ensuring the callback was invoked when the asynchronous operation completed. The Begin method would also construct an instance of a type that implemented IAsyncResult, using the optional state to populate that IAsyncResult‘s AsyncState property.
    */
    public int EndDoStuff(IAsyncResult asyncResult);
}
```

```
namespace System
{
    public interface IAsyncResult
    {
        object? AsyncState { get; }
        WaitHandle AsyncWaitHandle { get; }
        bool IsCompleted { get; }
        bool CompletedSynchronously { get; }
    }

    public delegate void AsyncCallback(IAsyncResult ar);
}
```


## Event-Based Asynchronous Pattern in .NET Framework 2.0
```
    class Handler
    {
        public int DoStuff(string arg);

        public void DoStuffAsync(string arg, object? userToken);
        public event DoStuffEventHandler? DoStuffCompleted;
    }

    public delegate void DoStuffEventHandler(object sender, DoStuffEventArgs e);

    public class DoStuffEventArgs : AsyncCompletedEventArgs
    {
        public DoStuffEventArgs(int result, Exception? error, bool canceled, object? userToken) :
            base(error, canceled, usertoken) => Result = result;

        public int Result { get; }
    }
```
