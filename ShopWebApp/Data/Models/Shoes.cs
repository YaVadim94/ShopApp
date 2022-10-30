namespace ShopWebApp.Data.Models;

/// <summary>
/// Контракт для обуви
/// </summary>
public class Shoes
{
    /// <summary> Идентификатор </summary>
    public long? Id { get; set; }
    
    /// <summary> Наименование модели </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary> Цвет модели </summary>
    public string Color { get; set; } = string.Empty;

    /// <summary> Цена </summary>
    public decimal Price { get; set; }
}