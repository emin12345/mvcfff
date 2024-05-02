using System.ComponentModel.DataAnnotations;

namespace Riode.Areas.Admin.ViewModels
{
    public class CategoryUpdateViewModel
    {
        [Required]
        public string Name { get; set; }
        public IFormFile? CategoryImage { get; set; }
    }
}
