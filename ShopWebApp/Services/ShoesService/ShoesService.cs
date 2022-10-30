using ShopWebApp.Data.Models;

namespace ShopWebApp.Services.ShoesService;

/// <summary>
/// Сервис для работы с обувью
/// </summary>
public class ShoesService : IShoesService
{
    /// <summary>
    /// Получить список всех моделей
    /// </summary>
    public async Task<List<Shoes>> GetAll()
    {
        await Task.CompletedTask;
            
        List<Shoes> shoesList = new()
        {
            CreateShoes("Тапка 1"),
            CreateShoes("Тапка 2"),
            CreateShoes("Тапка 3"),
            CreateShoes("Тапка 4"),
            CreateShoes("Тапка 5"),
            CreateShoes("Тапка 5"),
            CreateShoes("Тапка 6"),
        };

        return shoesList;
    }

    private static Shoes CreateShoes(string name) =>
        new()
        {
            Name = name,
            Color = "белый",
            Price = new decimal(new Random().Next(1000, 9999))
        };
}