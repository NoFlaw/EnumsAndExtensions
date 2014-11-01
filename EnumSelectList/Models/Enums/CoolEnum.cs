using System.ComponentModel.DataAnnotations;

namespace EnumsAndExtensions.Models.Enums
{
    public enum CoolEnum
    {
        [Display(Name = @"Low - 'L'")]
        Low = 1,
       
        [Display(Name = @"Medium - 'M'")]
        Medium = 2,

        [Display(Name = @"High - 'H'")]
        High = 3,
    };
}