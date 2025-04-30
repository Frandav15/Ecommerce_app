using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Entities.Utils;

namespace Ecommerce.Application.Interfaces
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId);
        Task<Product> CreateAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<bool> DeleteAsync(int id);
        Task<Page<Product>> ObtenerFiltradosAsync(string terminoBusqueda, List<int> categoriasSeleccionadas, int? rangoPrecio, int pagina, int tamanoPagina);

    }
}
