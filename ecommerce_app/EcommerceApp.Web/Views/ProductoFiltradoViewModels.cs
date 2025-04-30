using Ecommerce.Domain.Entities;

namespace EcommerceApp.Web.Views
{
    public class ProductoFiltradoViewModels
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
