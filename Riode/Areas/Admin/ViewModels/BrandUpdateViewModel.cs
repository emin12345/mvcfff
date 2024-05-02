using System.ComponentModel.DataAnnotations;

namespace Riode.Areas.Admin.ViewModels;
public class BrandUpdateViewModel
{
    [Required]
    public string Name { get; set; }
    public IFormFile? Logo { get; set; }
}
