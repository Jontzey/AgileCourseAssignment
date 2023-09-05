using AgileCourseAssignment.Client.Services;
using AgileCourseAssignment.Server.Data;
using AgileCourseAssignment.Server.Repo;
using Blazored.Modal;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddBlazoredModal();

var ConnectionString = builder.Configuration.GetConnectionString("FlagScapeConnection") ?? throw new InvalidOperationException("Connection string 'FlagScapeConnection' not found.");
builder.Services.AddDbContext<FlagScapeDb>(options =>
    options.UseSqlServer(ConnectionString));
builder.Services.AddScoped<IFlagRepo, FlagRepo>();
builder.Services.AddScoped<IHighScoreRepo, HighScoreRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
}

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
