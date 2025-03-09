var builder = DistributedApplication.CreateBuilder(args);

var ollama = builder.AddOllama(name:"ollama").WithDataVolume();

var llmModel = ollama.AddHuggingFaceModel(name: "llama", modelName: "bartowski/Llama-3.2-1B-Instruct-GGUF:Llama-3.2-1B-Instruct-IQ4_XS.gguf");

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.AsApp2ollama_ApiService>("apiservice");

builder.AddProject<Projects.AsApp2ollama_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WithReference(llmModel)
    .WaitFor(apiService);

builder.Build().Run();
