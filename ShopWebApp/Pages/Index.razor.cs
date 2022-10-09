using System.Diagnostics.CodeAnalysis;
using AntDesign;
using Microsoft.AspNetCore.Components;
using ShopWebApp.Data.Models;
using ShopWebApp.Frontend.Services.FileService;
using ShopWebApp.Frontend.Services.ShoesService;

namespace ShopWebApp.Pages;

/// <summary>
/// Логика главной страницы
/// </summary>
public partial class Index : ComponentBase
{
    private const int RowElementCount = 4;
    private int _showedCardCount;

    [Inject]
    [MemberNotNull]
    private IShoesService ShoesService { get; set; } = null!;

    [Inject] private IFileService FileService { get; set; } = null!;

    /// <summary>
    /// Список обуви
    /// </summary>
    [Parameter]
    public List<Shoes> Shoes { get; set; } = new();
    
    /// <summary>
    /// Инициалзация
    /// </summary>
    protected override async Task OnInitializedAsync()
    {
        await AddRow();
    }

    private async Task AddRow()
    {
        var row = await ShoesService.GetAll();
        Shoes.AddRange(row);
    }

    private RenderFragment ShowPicture()
    {
        const string fileUrl = @"D:\Programming\Repositories\123\ShopApp\ShopWebApp\Assets\pic1.jpg";

        return builder => builder.AddMarkupContent(1, $"<img alt=\"example\" src={fileUrl}/>");
    }
        

    private async Task<bool> HandleRemove(UploadFileItem file)
    {
        return await Task.FromResult(true);
    }
}