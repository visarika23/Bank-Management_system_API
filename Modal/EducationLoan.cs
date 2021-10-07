using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagementSystemAPI.Modal
{
    [Table("EducationLoans")]
    public class EducationLoan
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public decimal CourseFee { get; set; }

        [Required]
        public string Course { get; set; }

        [Required]
        public string FatherName { get; set; }

        [Required]
        public string FatherOccupation { get; set; }

        [Required]
        public int FatherTotalExp { get; set; }

        [Required]
        public string FatherExpCurr { get; set; }

        [Required]
        public string RationNo { get; set; }

        [Required]
        public decimal AnnualIncome { get; set; }
    }
}
