namespace ShopWebApp.Services.FileService;

/// <summary>
/// Сервис для работы с файлами
/// </summary>
public class FileService : IFileService
{
    /// <summary>
    /// Получить адрес файла
    /// </summary>
    public Task<string> GetUrl()
    {
        var url = @"D:\Programming\Repositories\123\ShopApp\ShopWebApp\Assets\pic1.jpg";

        return Task.FromResult(url);
    }
}