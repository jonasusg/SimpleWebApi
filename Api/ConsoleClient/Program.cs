// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var httpClient = new HttpClient();

var response = await httpClient.GetStringAsync("http://localhost:5000/WeatherForecast");

var response2 = await httpClient.GetStringAsync("http://localhost:5000/WeatherForecast");

Console.WriteLine(response);