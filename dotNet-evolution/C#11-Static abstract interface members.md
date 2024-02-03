


```cs

public interface IRequestConfig
{
    static abstract string Url { get; }
    static abstract HttpMethod Method { get; }
}

public class GetRequestToSomeUrl : IRequestConfig
{
    public static string Url => "https://someurl.com";
    public static HttpMethod Method => HttpMethod.Get;
}

public class Request
{
    public void DoRequest<T>() where T : IRequestConfig
    {
        var url = T.Url;
        var method = T.Method;
        //do request
    }
}
```
