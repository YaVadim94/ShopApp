using Microsoft.AspNetCore.Components;
using ShopWebApp.Data.Models;

namespace ShopWebApp.Components;

/// <summary>
/// Карточка для отображения обуви
/// </summary>
public partial class ShoesCard : ComponentBase
{
    /// <summary> Пара обуви </summary>
    [Parameter]
    public Shoes? Shoes { get; set; }

}