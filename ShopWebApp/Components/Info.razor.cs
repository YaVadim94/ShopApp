using Microsoft.AspNetCore.Components;
using ShopWebApp.Data.Models;

namespace ShopWebApp.Components;

/// <summary>
/// Компонент с информацией
/// </summary>
public partial class Info : ComponentBase
{
    /// <summary> Строка поиска </summary>
    private string Search { get; set; } = string.Empty;
    
    /// <summary> Корзина </summary>
    [Parameter]
    public Cart? Cart { get; set; }
}