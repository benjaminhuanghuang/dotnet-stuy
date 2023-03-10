using System.Text;
using Newtonsoft.Json;

using ask;

if( args.Length > 0) {
    HttpClient client = new HttpClient();
    
    client.DefaultRequestHeaders.Add("authorization", $"Bearer ${Key.GPT}");

    /*
        https://platform.openai.com/docs/api-reference/completions

        curl https://api.openai.com/v1/completions \
            -H 'Content-Type: application/json' \
            -H 'Authorization: Bearer YOUR_API_KEY' \
            -d '{
                "model": "text-davinci-003",
                "prompt": "Say this is a test",
                "max_tokens": 7,
                "temperature": 0
            }'
    */
    var content = new StringContent("{\"model\": \"text-davinci-001\", \"prompt\": \""+ args[0] +"\",\"temperature\": 1,\"max_tokens\": 100}",
        Encoding.UTF8, "application/json");

    HttpResponseMessage response = await client.PostAsync("https://api.openai.com/v1/completions", content);

    string responseString = await response.Content.ReadAsStringAsync();

    try
    {
        var dyData = JsonConvert.DeserializeObject<dynamic>(responseString);

        string guess = GuessCommand(dyData!.choices[0].text);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"---> My guess at the command prompt is: {guess}");
        Console.ResetColor();

    }
    catch(Exception ex)
    {
        Console.WriteLine($"---> Could not deserialize the JSON: {ex.Message}");
    }
}
else {
    Console.WriteLine("---> You need to provide some input");
}


static string GuessCommand(string raw)
{
    Console.WriteLine("---> GPT-3 API Returned Text:");
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(raw);

    var lastIndex = raw.LastIndexOf('\n');

    string guess = raw.Substring(lastIndex + 1);

    Console.ResetColor();

    TextCopy.ClipboardService.SetText(guess);

    return guess;
}