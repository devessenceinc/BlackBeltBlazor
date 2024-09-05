using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlackBeltBlazor.Client.Models;
using BlackBeltBlazor.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
builder.Services.AddSingleton(httpClient);

builder.Services.AddScoped<AppState>();
builder.Services.AddScoped<IWeatherService, WeatherService>();

await builder.Build().RunAsync();
