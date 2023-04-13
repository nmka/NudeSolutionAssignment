using Microsoft.AspNetCore.HttpLogging;
using NudeSolutionAssignment.Modules.Insurance.Repositories;
using NudeSolutionAssignment.Modules.Insurance.Services;
using NudeSolutionAssignment.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<InsuranceContext>();

builder.Services.AddScoped<IItemsService, ItemsService>();
builder.Services.AddScoped<ICategoriesService, CategoriesService>();

builder.Services.AddScoped<IItemsRepository, ItemsRepository>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Logging
builder.Services.AddHttpLogging(httpLogging =>
{
    httpLogging.LoggingFields = HttpLoggingFields.All;
});

var app = builder.Build();
app.UseSwaggerUI();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSwagger(x => x.SerializeAsV2 = true);
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
