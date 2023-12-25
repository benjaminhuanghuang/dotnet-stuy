using Azure;
using Azure.AI.OpenAI;
using Microsoft.Extensions.Configuration;


var builder = new ConfigurationBuilder()
    .AddUserSecrets<Program>();
var configuration = builder.Build();

string openAlEndpoint = "https://letslearnai.openai.azure.com/";
string openAIAPIKEY = configuration["APIKEY"];

string openAIDeploymentName - "learngpt35";

var endpoint = new Uri(openAlEndpoint);
var credential = new AzureKeyCredential(openAIAPIKEY);
var openAIClient = new OpenAIServiceClient(credential, endpoint);

var completionOptions = new ChatCompletionsOptions
{
    MaxTokens=400,
    Temperature=1f,
    FrequencyPenalty=0.0f,
    PresencePenalty=0.0f,
    NucleusSamplingFactor = 0.95f // Top P
};
var systemPrompt = 
"""
You are a hiking enthusiast who helps people discover fun hikes. You are upbeat and friendly. 
You ask people what type of hikes they like to take and then suggest some.
""";

ChatMessage assistantResponse = response.Choices[0].Message;
completionOptions.Messages.Add(systemMessage);


string userGreeting = """
Hi there hiking recommendation bot! 
Can't wait to hear what you have in store for me!
""";
ChatMessage userGreetingMessage = new (ChatRole.User, userGreeting);
completionOptions.Messages.Add(userGreetingMessage);

Console.WriteLine($"User >>> {userGreeting}{Environment.NewLine}");
ChatCompletions response = await openAIClient.GetChatCompletionsAsync(openAIDeploymentName, completionOptions);

ChatMessage assistantResponse = response.Choices[0].Message;

Console.WriteLine($"AI >>> {assistantResponse.Content}");
