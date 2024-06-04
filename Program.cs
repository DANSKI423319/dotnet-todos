var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApiDocument();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi(); // UseSwaggerUI Protected by if (env.IsDevelopment())
}

app.MapGet("/", () => "Hello World!");

app.Run();
