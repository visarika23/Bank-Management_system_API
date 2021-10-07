using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankManagementSystemAPI.Modal;
using BankManagementSystemAPI.Provider;

namespace BankManagementSystemAPI.Repository
{
    public class UserRepo : IUserRepo
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(UserRepo));
        private static BankDBContext _context;

        public UserRepo(BankDBContext context)
        {
            _context = context;
        }

        public string login(UserLogin cred)
        {
            _log4net.Info("Verifying user credentials...");
            try
            {
                var user= _context.Users.Where(x => x.Username == cred.Username && x.Password == cred.Password).ToList();
               
                var data = user[0];
                return data.ID;
            }
            catch(Exception ex)
            {
                _log4net.Error($"Some error occurred while logging in user!\n {ex.Message}");
                return null;
            }

        }

        public bool addUser(UserRegister user)
        {
            _log4net.Info("Adding user to db...");
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                _log4net.Info("User added in db...");
                return true;

            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while registering user!\n {ex.Message}");
                return false;
            }
        }

        public bool addLoan(LoanForm loan)
        {
            _log4net.Info("Adding loan to db...");
            try
            {
                
                _context.Loans.Add(loan);
                _context.SaveChanges();
                _log4net.Info("Loan added in db...");
                return true;

            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding loan!\n {ex.Message}");
                return false;
            }
        }

        public bool addEducationLoan(EducationLoan loan)
        {
            _log4net.Info("Adding education loan to db...");
            try
            {
                
                _context.EducationLoans.Add(loan);
                _context.SaveChanges();
                _log4net.Info("Education Loan added in db...");
                return true;

            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding education loan!\n {ex.Message}");
                return false;
            }
        }
        public bool addPersonalLoan(PersonalLoan loan)
        {
            _log4net.Info("Adding personal loan to db...");
            try
            {
                _context.PersonalLoans.Add(loan);
                _context.SaveChanges();
                _log4net.Info("Loan added in db...");
                return true;

            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding personal loan!\n {ex.Message}");
                return false;
            }
        }

        public UserRegister userDetails(string id)
        {
            _log4net.Info("Fetching user details from db...");
            try
            {
                List<UserRegister> user = _context.Users.Where(x => x.ID == id).ToList();
                // var details = user.SelectMany(s => (s.Name, s.GuardianType)).ToList();
                var data = user[0];

                return data;
            }
            catch(Exception ex)
            {
                _log4net.Error($"Some error occurred while fetching user details for updation!\n {ex.Message}");
                return null;
            }

        }

        public IEnumerable<UserRegister> getUsers()
        {
            try
            {
                List<UserRegister> users = _context.Users.ToList();
                return users;
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while fetching user details for updation!\n {ex.Message}");
                return null;
            }
        }

        public IEnumerable<LoanForm> getLoanUsers()
        {
            try
            {
                List<LoanForm> users = _context.Loans.ToList();
                return users;
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while fetching user details for updation!\n {ex.Message}");
                return null;
            }
        }
    }
}
