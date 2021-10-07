using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankManagementSystemAPI.Modal;

namespace BankManagementSystemAPI.Repository
{
    public interface IUserRepo
    {
        public string login(UserLogin cred);
        public bool addUser(UserRegister user);
        public bool addLoan(LoanForm loan);
        public bool addEducationLoan(EducationLoan loan);
        public bool addPersonalLoan(PersonalLoan loan);
        public UserRegister userDetails(string id);
        public IEnumerable<UserRegister> getUsers();
        public IEnumerable<LoanForm> getLoanUsers();
    }
}
