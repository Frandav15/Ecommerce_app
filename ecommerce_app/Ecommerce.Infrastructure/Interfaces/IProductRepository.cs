
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Entities.Utils;

namespace Ecommerce.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId);
        Task<Product> AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
        Task<Page<Product>> ObtenerFiltradosAsync(string terminoBusqueda, List<int> categoriasSeleccionadas, int? rangoPrecio, int pagina, int tamanoPagina);
    }
}
