using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace ShopWebApp.Components;

/// <summary>
/// Компонент с предустановленным шрифтом
/// </summary>
public partial class SansSerifText : ComponentBase
{
    /// <summary> Размер шрифта </summary>
    [Parameter]
    public int FontSize { get; set; } = 10;

    /// <summary> Цвет </summary>
    [Parameter]
    public string Color { get; set; } = Colors.Grey.Darken1;
    
    /// <summary> Содержимое </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}