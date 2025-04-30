using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Entities.Utils
{
    public class ProductosFiltrados
    {
        public IEnumerable<Product>? Productos { get; set; }
        public IEnumerable<Category>? Categorias { get; set; }
        public int PaginaActual { get; set; }
        public int TotalPaginas { get; set; }
        public string? TerminoBusqueda { get; set; }
        public List<int>? CategoriasSeleccionadas { get; set; }
        public int? RangoPrecio { get; set; }

    }
}
