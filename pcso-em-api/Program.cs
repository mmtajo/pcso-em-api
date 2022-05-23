var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.MapGet("Hello", () => "Hello from dotnet six API");
app.MapGet("Product", () => "Get some Product from Azure SQL");

app.MapPost("Product", (Product p) => "Product saved in SQL");
app.MapPost("Chat", (Message msg) => "Message posted to chat SQL");


app.Run();

public record class Message(string Name, string Msg);

public record class Product(string Name, string Picture, int Price);
