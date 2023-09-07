using AgileCourseAssignment.Client;
using AgileCourseAssignment.Client.Services;
using Blazored.Modal;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddBlazoredModal();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IFlagService, FlagService>();
builder.Services.AddScoped<IHighScoreService, HighScoreService>();
builder.Services.AddScoped<INewsService, NewsService>();

await builder.Build().RunAsync();
