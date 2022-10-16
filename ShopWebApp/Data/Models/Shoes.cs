namespace ShopWebApp.Data.Models;

/// <summary>
/// Контракт для обуви.
/// </summary>
public class Shoes
{
    /// <summary>
    /// Наименование модели.
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// Артикул модели.
    /// </summary>
    public int VendorCode { get; set; }

    /// <summary>
    /// Тип модели.
    /// </summary>
    public int Type { get; set; }

    /// <summary>
    /// Цвет модели.
    /// </summary>
    public int Color { get; set; }

    /// <summary>
    /// Описание
    /// </summary>
    public string GetDescription() =>
        $"цвет: {Color}, тип: {Type}, артикул: {VendorCode}";
}