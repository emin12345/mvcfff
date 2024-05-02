using Microsoft.Build.Framework;

namespace Riode.Areas.Admin.ViewModels
{
    public class BrandCreateViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public IFormFile Logo { get; set; }
    }
}
