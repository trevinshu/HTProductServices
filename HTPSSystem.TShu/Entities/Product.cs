using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion
namespace HTPSSystem.TShu.Entities
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage ="Name is required")]
        [StringLength(50, ErrorMessage = "Name is limited to 50 characters")]
        public string ModelNumber { get; set; }
        [Required(ErrorMessage = "Model Number is required")]
        [StringLength(50, ErrorMessage = "Model Number is limited to 15 characters")]
        public Boolean Discontinued 
        {  
            set
            {
                Discontinued = true;
            }
        }
        public DateTime DiscontinuedDate 
        {  
            set
            {
                DiscontinuedDate = DateTime.Now;
            }
        }
    }
}
