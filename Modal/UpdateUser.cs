using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankManagementSystemAPI.Modal
{
    public class UpdateUser
    {
     
        public string Name { get; set; }   
        public string GuardianType { get; set; } 
        public string GuardianName { get; set; }
        public string Address { get; set; }
        public string Citizenship { get; set; }
        public string state { get; set; }
        public string Country { get; set; } 
        public string Email { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string Number { get; set; }
        public DateTime Dob { get; set; }
        public string AccountType { get; set; }
        public string BranchName { get; set; }    
        public string CitizenStatus { get; set; }
        public decimal InitialDepositAmount { get; set; }
        public string IdProofType { get; set; }
        public string IdDocNumber { get; set; }
        public string RefAcctHolderName { get; set; }
        public string RefAcctHolderAccNo { get; set; }
        public string RefAcctHolderAdd { get; set; }
    }
}
