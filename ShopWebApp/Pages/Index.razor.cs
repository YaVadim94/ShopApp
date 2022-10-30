using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;
using ShopWebApp.Data.Models;
using ShopWebApp.Services.FileService;
using ShopWebApp.Services.ShoesService;

namespace ShopWebApp.Pages;

/// <summary>
/// Логика главной страницы
/// </summary>
public partial class Index : ComponentBase
{
    [Inject]
    [MemberNotNull]
    private IShoesService ShoesService { get; set; } = null!;

    [Inject]
    private IFileService FileService { get; set; } = null!;

    /// <summary> Корзина </summary>
    private Cart Cart { get; set; } = new();

    /// <summary>
    /// Инициализация
    /// </summary>
    protected override void OnInitialized()
    {
        Cart.ShoesList.Add(new Shoes
        {
            Id = 1,
            Color = "Белый",
            Name = "Танк",
            Price = new decimal(2990.90)
        });
        
        Cart.ShoesList.Add(new Shoes
        {
            Id = 2,
            Color = "Черный",
            Name = "Сабо",
            Price = new decimal(4990.90)
        });
        
        Cart.ShoesList.Add(new Shoes
        {
            Id = 3,
            Color = "Черный",
            Name = "Крутые",
            Price = new decimal(1990.90)
        });
        
        Cart.ShoesList.Add(new Shoes
        {
            Id = 4,
            Color = "Черный",
            Name = "Новые",
            Price = new decimal(8990.90)
        });
    }
}