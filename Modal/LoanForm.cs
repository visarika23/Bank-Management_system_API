using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace BankManagementSystemAPI.Modal
{
    [Table("Loans")]
    public class LoanForm
    {
        [Key, Column(Order = 0)]
        public string ID { get; set; }

        [Key, Column(Order = 1)]
        public string LoanType { get; set; }

        [Required]
        public decimal LoanAmount { get; set; }

        [Required]
        public DateTime ApplyDate { get; set; }

        [Required]
        public DateTime IssueDate { get; set; }

        [Required]
        public int RateofInterest { get; set; }

        [Required]
        public int LoanDuration { get; set; }

    }
}
