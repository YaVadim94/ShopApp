using ShopWebApp.Data.Models;

namespace ShopWebApp.Frontend.Services.ShoesService
{
    /// <summary>
    /// Сервис для работы с обувью
    /// </summary>
    public interface IShoesService
    {
        /// <summary>
        /// Получить список всех моделей
        /// </summary>
        Task<IEnumerable<Shoes>> GetAll();
    }
}
