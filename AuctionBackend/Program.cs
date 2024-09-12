using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Dodaj us³ugi do kontenera
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("https://localhost:5001") // Adres projektu Blazor WebAssembly
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();

// Skonfiguruj potok HTTP
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
