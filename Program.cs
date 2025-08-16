using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthorization();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

// This is the mock endpoint for text input
app.MapPost("/estimate", ([FromBody] DishNameRequest request) =>
{
    var response = new CarbonFootprintResponse
    {
        Dish = request.Dish,
        EstimatedCarbonKg = 4.2M,
        Ingredients = new List<Ingredient>
        {
            new Ingredient { Name = "Rice", CarbonKg = 1.1M },
            new Ingredient { Name = "Chicken", CarbonKg = 2.5M },
            new Ingredient { Name = "Spices", CarbonKg = 0.2M },
            new Ingredient { Name = "Oil", CarbonKg = 0.4M }
        }
    };

    return Results.Ok(response);
});

// This is the mock endpoint for image input (corrected)
app.MapPost("/estimate/image", async (HttpRequest request) =>
{
    var formData = await request.ReadFormAsync();
    var image = formData.Files["image"];
    
    var response = new CarbonFootprintResponse
    {
        Dish = "Chicken Biryani (from image)",
        EstimatedCarbonKg = 4.2M,
        Ingredients = new List<Ingredient>
        {
            new Ingredient { Name = "Rice", CarbonKg = 1.1M },
            new Ingredient { Name = "Chicken", CarbonKg = 2.5M },
            new Ingredient { Name = "Spices", CarbonKg = 0.2M },
            new Ingredient { Name = "Oil", CarbonKg = 0.4M }
        }
    };

    return Results.Ok(response);
});

app.Run();

public class CarbonFootprintResponse
{
    public string Dish { get; set; }
    public decimal EstimatedCarbonKg { get; set; }
    public List<Ingredient> Ingredients { get; set; }
}

public class Ingredient
{
    public string Name { get; set; }
    public decimal CarbonKg { get; set; }
}

public class DishNameRequest
{
    public string Dish { get; set; }
}