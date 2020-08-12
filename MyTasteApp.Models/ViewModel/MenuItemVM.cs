using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyTasteApp.Models.ViewModel
{
    public class MenuItemVM
    {
        public MenuItem MenuItem { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> FoodTypeList { get; set; }
    }
}