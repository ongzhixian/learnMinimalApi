// No 'using' statements needed -- .NET 6 compiler figures out using statements for you. Yay!
// As you add more features, like Entity Framework for example, you will need to add using statements, but for a simple API like the above, you don't need them yet.
// ZX: Ok. So the question then becomes when do I need to add 'using' statements; kiv
//

using Microsoft.OpenApi.Models;
using PizzaStore.DB;

var builder = WebApplication.CreateBuilder(args);

// Add services

// Add CORS
// builder.Services.AddCors(options => {});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { 
        Title = "Todo API", 
        Description = "Keep track of your tasks", 
        Version = "v1" 
    });
});


var app = builder.Build();

// if (app.Environment.IsDevelopment())
// {
//     app.UseDeveloperExceptionPage();
// }

// Add CORS middleware

// app.UseCors("some unique string");
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
});

// Add routing
app.MapGet("/", () => "Hello World!");

// app.MapGet("/products", () => data);
// app.MapGet("/product", () => new { id = 1 });
// app.MapGet("/products/{id}", (int id) => data.SingleOrDefault(product => product.id == id);
// app.MapPost("/product", (Product product) => {});

app.MapGet("/pizzas/{id}", (int id) => PizzaDB.GetPizza(id));
app.MapGet("/pizzas", () => PizzaDB.GetPizzas());
app.MapPost("/pizzas", (Pizza pizza) => PizzaDB.CreatePizza(pizza));
app.MapPut("/pizzas", (Pizza pizza) => PizzaDB.UpdatePizza(pizza));
app.MapDelete("/pizzas/{id}", (int id) => PizzaDB.RemovePizza(id));


app.Run();
