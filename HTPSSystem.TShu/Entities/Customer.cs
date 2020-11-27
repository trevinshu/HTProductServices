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
    [Table("Customer")]
    public class Customer
    {
        private string _ContactNumber;
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, ErrorMessage = "First Name is limited to 50 characters.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, ErrorMessage = "Last Name is limited to 50 characters.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [StringLength(100, ErrorMessage = "Email is limited to 50 characters.")]
        public string ContactNumber
        {
            get
            {
                return _ContactNumber;

            }

            set
            {
                _ContactNumber = string.IsNullOrEmpty(value) ? null : value;
                
            }
        }

        [NotMapped]
        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }
    }
}
