var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();



app.MapGet("Hello", () => "Hello from Philippines");
app.MapGet("Product", () => "Get Products from Philippines");


app.MapPost("Product", (Product p) => "Product Saved in SQL");
app.MapDelete("Product", (string name) => "Deleted");

app.MapPost("Chat", (Message msg) => "Message Posted to chat SQL");

app.Run();

//Some Data Contracts
public record class Message(string Name, string Msg);
public record class Product(string Name, string Picture, int Price);