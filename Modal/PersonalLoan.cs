using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagementSystemAPI.Modal
{
    [Table("PersonalLoans")]
    public class PersonalLoan
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public decimal AnnualIncome { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        public int TotalExp { get; set; }

        [Required]
        public string ExpCurr { get; set; }
    }
}
