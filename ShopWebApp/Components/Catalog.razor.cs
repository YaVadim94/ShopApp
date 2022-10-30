using Microsoft.AspNetCore.Components;
using ShopWebApp.Data.Models;
using ShopWebApp.Services.ShoesService;

namespace ShopWebApp.Components;

/// <summary>
/// Каталог
/// </summary>
public partial class Catalog : ComponentBase
{
    /// <summary> Сервис для работы с обувью </summary>
    [Inject] 
    public IShoesService? ShoesService { get; set; }

    /// <summary> Список пар обуви </summary>
    private List<Shoes> ShoesList { get; set; } = new();
    
    /// <summary>
    /// Инициализация
    /// </summary>
    protected override async Task OnInitializedAsync()
    {
        if (ShoesService != null) 
            ShoesList = await ShoesService.GetAll();
    }
}