using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace BTL_dotnet2.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Category ID")]
        [StringLength(20)]
        public string CategoryID { get; set; }

        [Display(Name = "Category Name")]
        [StringLength(200, MinimumLength = 2)]

        public string CategoryName { get; set; }
    }
}
