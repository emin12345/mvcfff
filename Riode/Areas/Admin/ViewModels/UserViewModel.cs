using Riode.Models;

namespace Riode.Areas.Admin.ViewModels;
public class UserViewModel
{
    public AppUser User { get; set; }
    public IList<string> Roles { get; set; } = null!;
}
