public class Program
{
    public static void Main(string[] args) => new WebHostBuilder()
        .UseKestrel() // web server
        .Configure(app => app.Run(context => context.Response.WriteAsync("Hello World!")))
        .Build()
        .Run();
}
