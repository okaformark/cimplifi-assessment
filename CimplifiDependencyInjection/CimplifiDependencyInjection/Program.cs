// See https://aka.ms/new-console-template for more information
using CimplifiDependencyInjection;


ConsoleLogger logger = new();
Application app = new(logger);
app.Log("Thank you for considering me for this role");

FileLogger fileLogger = new("message.txt");

Application fileApp = new (fileLogger);
fileApp.Log("I look forward to hearing from you");
Console.ReadKey();
