using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MinWebApi.Repositories;
using MinWebApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IRepository<Product>, Repository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.MapGet("/getproducts", (IRepository<Product> repository) => repository.GetAll());
app.MapGet("/getproduct/{id}", (IRepository<Product> repository, string id) => repository.GetById(id));
app.MapPost("/addproduct", (IRepository<Product> repository, Product product) => repository.Create(product));
app.MapDelete("/deleteproduct/{id}", (IRepository<Product> repository, string id) => repository.Delete(id));

app.MapSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Minimal API v1"));
app.UseCors();
app.Run();