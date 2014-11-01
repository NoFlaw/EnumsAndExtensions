using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using EnumsAndExtensions.Models.Enums;

namespace EnumsAndExtensions.Models
{
    public class ListViewModel
    {
        [Display(Name = "EnumList")]
        public int SelectedEnumItemId { get; set; }

        public IEnumerable<SelectListItem> EnumList { get; set; }

        public CoolEnum MyCoolEnum { get; set; }
    }
}