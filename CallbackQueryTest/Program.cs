using BotFramework;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTelegramBot();
    })
    .Build();

await host.RunAsync();