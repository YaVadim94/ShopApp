using ShopWebApp.Services.FileService;
using ShopWebApp.Services.ShoesService;

namespace ShopWebApp.Extensions;

/// <summary>
/// Расширения дял конфигурации приложения
/// </summary>
public static class StartupExtensions
{
    /// <summary>
    /// Зарегистрировать сервисы приложения
    /// </summary>
    public static IServiceCollection RegisterAppServices(this IServiceCollection services)
    {
        services
            .AddTransient<IFileService, FileService>()
            .AddTransient<IShoesService, ShoesService>();

        return services;
    }
}