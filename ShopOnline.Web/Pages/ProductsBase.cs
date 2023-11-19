using Microsoft.AspNetCore.Components;
using ShopOnline.Models.DTO;
using ShopOnline.Web.Services.Contracts;
using System.Reflection;

namespace ShopOnline.Web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; } = null!;
        public IEnumerable<ProductDto> Products{ get; set; } = null!;
        protected override async Task OnInitializedAsync()
        {
            Products = await ProductService.GetItems();
        }
    }
}
