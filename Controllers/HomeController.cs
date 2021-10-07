using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankManagementSystemAPI.Modal;
using BankManagementSystemAPI.Repository;

namespace BankManagementSystemAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(HomeController));
        private static IUserRepo _repo;

        public HomeController(IUserRepo repo)
        {
            _repo = repo;
        }
       
        [HttpPost]
        [Route("Login")]
        public string Login([FromBody] UserLogin cred)
        {
            _log4net.Info("Logging in User...");
            try
            {
                var result = _repo.login(cred);
                if (result == null)
                {
                    _log4net.Info("Credentials not verified. Cannot login user...");
                    return null;
                }
                _log4net.Info("Credential verified. User succesfully login...");

                return result;
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while logging in user!\n {ex.Message}");
                return null;
            }

        }

        [HttpPost]
        [Route("Register")]

        public ActionResult RegisterUser([FromBody] UserRegister user)
        {
            _log4net.Info("Registering User...");
            try
            {
                if (user == null)
                {
                    _log4net.Info("User is null. Cannot register user...");
                    return NoContent();
                }

                bool result= _repo.addUser(user);

                if (result == false)
                {
                    _log4net.Info("Cannot register user...");
                    return BadRequest();
                }
                _log4net.Info("User succesfully registered...");
               
                return Ok();
            }
            catch(Exception ex)
            {
                _log4net.Error($"Some error occurred while registering user!\n {ex.Message}");
                return null;
            }
        }


        [HttpPost]
        [Route("Loan")]
        public ActionResult ApplyLoan([FromBody] LoanForm loan)
        {
            _log4net.Info("Adding Loan...");
            try
            {
                if (loan == null)
                {
                    _log4net.Info("Loan object is null. Cannot add loan...");
                    return NoContent();
                }

                bool result = _repo.addLoan(loan);

                if (result == false)
                {
                    _log4net.Info("Cannot add loan...User tried adding duplicate record into db");
                    return BadRequest();
                }
                _log4net.Info("Loan succesfully added...");

                return Ok();
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding loan!\n {ex.Message}");
                return null;
            }
        }


        [HttpPost]
        [Route("EducationLoan")]
        public ActionResult ApplyEducationLoan([FromBody] EducationLoan loan)
        {
            _log4net.Info("Adding Education Loan...");
            try
            {
                if (loan == null)
                {
                    _log4net.Info("Education Loan object is null. Cannot add Education loan...");
                    return NoContent();
                }

                bool result = _repo.addEducationLoan(loan);

                if (result == false)
                {
                    _log4net.Info("Cannot add education loan...User tried adding duplicate record into db");
                    return BadRequest();
                }
                _log4net.Info("Education Loan succesfully added...");

                return Ok();
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding education loan!\n {ex.Message}");
                return null;
            }
        }


        [HttpPost]
        [Route("PersonalLoan")]
        public ActionResult ApplyPersonalLoan([FromBody] PersonalLoan loan)
        {
            _log4net.Info("Adding Personal Loan...");
            try
            {
                if (loan == null)
                {
                    _log4net.Info("Personal Loan object is null. Cannot add personal loan...");
                    return NoContent();
                }

                bool result = _repo.addPersonalLoan(loan);

                if (result == false)
                {
                    _log4net.Info("Cannot add personal loan...User tried adding duplicate record into db");
                    return BadRequest();
                }
                _log4net.Info("Personal Loan succesfully added...");

                return Ok();
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding personal loan!\n {ex.Message}");
                return null;
            }
        }

      /*  [HttpGet("{id}")]
        [Route("Update")]
        public UserRegister GetDetails(string id)
        {
            _log4net.Info("Getting user details for updation...");
            try
            {
                if (id == null)
                {
                    _log4net.Info("Personal Loan object is null. Cannot add personal loan...");
                    return null;
                }

                var result = _repo.userDetails(id);

                if (result == null)
                {
                    _log4net.Info("Cannot add personal loan...User tried adding duplicate record into db");
                    return null;
                }
                _log4net.Info("Personal Loan succesfully added...");

                return result;
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding personal loan!\n {ex.Message}");
                return null;
            }

        }
*/
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
        }

        [HttpGet]
        [Route("Users")]
        public IEnumerable<UserRegister> GetUsers()
        {
            try
            {
                var userList = _repo.getUsers();
                return userList;
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding personal loan!\n {ex.Message}");
                return null;
            }
        }
/*
        [HttpGet]
        [Route("Users")]
        public IEnumerable<LoanForm> GetLoanApplications()
        {
            try
            {
                var userList = _repo.getLoanUsers();
                return userList;
            }
            catch (Exception ex)
            {
                _log4net.Error($"Some error occurred while adding personal loan!\n {ex.Message}");
                return null;
            }
        }*/
    }
}
