// See https://aka.ms/new-console-template for more information

using WelcomeApp;

Console.WriteLine("Welcome to authentication app");
SignIn obj = new SignIn();
Console.WriteLine(obj.Authenticate("admin", "admin@1256"));