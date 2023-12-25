# Let's Learn .NET - AI
https://www.youtube.com/watch?v=ZpBkrrYWPTE

https://aka.ms/letslearn/dotnet/ai

## Create OpenAI resource
17:05

Azure portal -> Create a resource -> Azure OpenAI
Name: letslearnai


## Deploy a model in Azure OpenAI Studio
https://oai.azure.com/portal

Management -> Deployment -> Create new Deployment -> Select a model = gpt-35-turbo, name = learnchatmodel

## Chat


## Text completion


## Generate text and conversations with .NET and Azure OpenAI Completions
https://learn.microsoft.com/en-us/training/modules/open-ai-dotnet-text-completions/?ns-enrollment-type=Collection&ns-enrollment-id=223xbrow102kkd

```bash
    dotnet new console -n HikingConversationsAI    
    
    cd HikingConversationsAI
    
    dotnet add package Azure.AI.OpenAI --prerelease
```

Go to the created openAI resources > Keys and Endpoint, find out the endpoint and key, and add them to the code.
```cs
using Azure;
using Azure.AI.OpenAI;

string openAlEndpoint = "";
string openAIAPIKEY = "";

string openA
```
