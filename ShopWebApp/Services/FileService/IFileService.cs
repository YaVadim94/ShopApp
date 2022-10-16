namespace ShopWebApp.Services.FileService;

/// <summary>
/// Сервис для работы с файлами
/// </summary>
public interface IFileService
{
    /// <summary>
    /// Получить адрес файла
    /// </summary>
    Task<string> GetUrl();
}