using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BankManagementSystemAPI.Modal;

namespace BankManagementSystemAPI.Provider
{
    public class BankDBContext : DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options) : base(options)
        {

        }

        public DbSet<UserRegister> Users { get; set; }
        public DbSet<LoanForm> Loans { get; set; }
        public DbSet<EducationLoan> EducationLoans { get; set; }
        public DbSet<PersonalLoan> PersonalLoans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /* var config = modelBuilder.Entity<UserRegister>();
             config.ToTable("RegisteredUser");*/

            modelBuilder.Entity<LoanForm>().HasKey(lf => new { lf.ID, lf.LoanType });
            modelBuilder.Entity<UserRegister>().HasKey(k => new { k.ID, k.Username });


            // modelBuilder.Entity<EducationLoan>().HasForeignKey(eL => new { eL.ID });
            base.OnModelCreating(modelBuilder);

        }
    }
}
