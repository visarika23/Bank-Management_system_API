using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagementSystemAPI.Modal
{
    
    public class UserRegister
    {
        [Key, Column(Order = 0)]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }


        [Key, Column(Order = 1)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string GuardianType { get; set; }

        [Required]
        public string GuardianName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Citizenship { get; set; }

        [Required]
        public string state { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [Column(TypeName= "nvarchar(16)")]
        public string AccountNo { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string MaritalStatus { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Number { get; set; }

        [Required]
        public DateTime Dob { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        [Required]
        public string AccountType { get; set; }

        [Required]
        public string BranchName { get; set; }

        [Required]
        public string CitizenStatus { get; set; }

        [Required]
        public decimal InitialDepositAmount { get; set; }

        [Required]
        public string IdProofType { get; set; }

        [Required]
        public string IdDocNumber { get; set; }

        [Required]
        public string RefAcctHolderName { get; set; }

        [Required]
        public string RefAcctHolderAccNo { get; set; }

        [Required]
        public string RefAcctHolderAdd { get; set; }
       

    }
}
