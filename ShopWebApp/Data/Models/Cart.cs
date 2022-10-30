namespace ShopWebApp.Data.Models;

/// <summary>
/// Корзина
/// </summary>
public class Cart
{
    /// <summary> Идентификатор </summary>
    public long? Id { get; set; }

    /// <summary> Список пар обуви, добавленных в корзину </summary>
    public List<Shoes> ShoesList { get; set; } = new();
}