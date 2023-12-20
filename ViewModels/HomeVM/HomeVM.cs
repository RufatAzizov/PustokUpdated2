using PustokMVC.Areas.Admin.ViewModels;
//using PustokMVC.ViewModels.CommonVM;
using PustokMVC.ViewModels.SliderVM;
using PustokMVC.Areas.Admin.ViewModels;

namespace PustokMVC.ViewModels.HomeVM
{
    public class HomeVM
    {
        public IEnumerable<AdminProductListItemVM> Products { get; set; }
        //public PaginatonVM<IEnumerable<AdminProductListItemVM>> PaginatedProducts { get; set; }
    }
}