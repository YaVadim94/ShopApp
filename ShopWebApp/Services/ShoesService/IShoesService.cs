using ShopWebApp.Data.Models;

namespace ShopWebApp.Services.ShoesService;

/// <summary>
/// Сервис для работы с обувью
/// </summary>
public interface IShoesService
{
    /// <summary>
    /// Получить список всех моделей
    /// </summary>
    Task<List<Shoes>> GetAll();
}