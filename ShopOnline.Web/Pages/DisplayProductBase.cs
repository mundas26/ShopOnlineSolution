using Microsoft.AspNetCore.Components;
using ShopOnline.Models.DTO;

namespace ShopOnline.Web.Pages
{
    public class DisplayProductBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; } = null!;
    }
}
