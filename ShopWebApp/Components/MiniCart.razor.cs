using Microsoft.AspNetCore.Components;
using ShopWebApp.Data.Models;

namespace ShopWebApp.Components;

/// <summary>
/// Компонент мини корзины
/// </summary>
public partial class MiniCart : ComponentBase
{
    private bool MiniCartShowed { get; set; } = false;

    private string Elevation => MiniCartShowed ? "mud-elevation-25" : "mud-elevation-0";

    private string Product => (Cart.ShoesList.Count % 10) switch
    {
        
        0 or 5 or 6 or 7 or 8 or 9 => "товаров",
        1 => "товар",
        2 or 3 or 4 => "товара",
        _ => string.Empty
    };

    /// <summary> Элементы корзины </summary>
    [Parameter]
    public Cart Cart { get; set; } = new();

    private void OnClickMiniCart()
    {
        if (MiniCartShowed)
            CloseMiniCart();
        else
            ShowMiniCart();
    }

    private void ShowMiniCart()
    {
        MiniCartShowed = true;
    }

    private void CloseMiniCart()
    {
        MiniCartShowed = false;
    }
}