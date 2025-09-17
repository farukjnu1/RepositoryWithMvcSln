using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace RepositoryWithMvc.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId
        {
            get;
            set;
        }

        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(10)]
        public string EmployeeName
        {
            get;
            set;
        }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        [StringLength(100)]
        public string Address
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Email Id is required")]
        [StringLength(100)]
        public string EmailId
        {
            get;
            set;
        }
    }
}