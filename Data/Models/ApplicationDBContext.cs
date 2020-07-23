using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Data.Models;

namespace EmployeeManagementSystem.Data.Models
{
    public class ApplicationDbContext : DbContext
    {
        #region Constructor
        public ApplicationDbContext() : base()
        {
        }
        public ApplicationDbContext(DbContextOptions options)
        : base(options)
        {
        }
        #endregion Constructor
        #region Methods
        protected override void OnModelCreating(ModelBuilder
        modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Map Entity names to DB Table names
            //modelBuilder.Entity<Customers>().ToTable("Customers");
            //modelBuilder.Entity<Employee9G>().ToTable("Employee9G");
            //modelBuilder.Entity<EmployeeACRID>().ToTable("EmployeeACRID");
            //modelBuilder.Entity<EmployeeAEP>().ToTable("EmployeeAEP");
            //modelBuilder.Entity<EmployeeCED>().ToTable("EmployeeCED");
            //modelBuilder.Entity<EmployeeDependents>().ToTable("EmployeeDependents");
            //modelBuilder.Entity<EmployeeECC>().ToTable("EmployeeECC");
            //modelBuilder.Entity<EmployeeInfo>().ToTable("EmployeeInfo");
            //modelBuilder.Entity<EmployeeMeals>().ToTable("EmployeeMeals");
            //modelBuilder.Entity<EmployeePassport>().ToTable("EmployeePassport");
            //modelBuilder.Entity<EmployeePWP>().ToTable("EmployeePWP");
            //modelBuilder.Entity<EmployeeVisa>().ToTable("EmployeeVisa");
            //modelBuilder.Entity<HomeLeaves>().ToTable("HomeLeaves");
            //modelBuilder.Entity<Locations>().ToTable("Locations");
            //modelBuilder.Entity<ResignationTransactions>().ToTable("ResignationTransactions");
            //modelBuilder.Entity<RFIDs>().ToTable("RFIDs");
            //modelBuilder.Entity<SanctionConfirmations>().ToTable("SanctionConfirmations");
            //modelBuilder.Entity<SanctionTypes>().ToTable("SanctionTypes");
            modelBuilder.Entity<Sites>().ToTable("Sites");
            //modelBuilder.Entity<Transactions>().ToTable("Transactions");
            //modelBuilder.Entity<TransactionTypes>().ToTable("TransactionTypes");

        }
        #endregion Methods
        #region Properties
        //public DbSet<Customers> Customers { get; set; }
        //public DbSet<Employee9G> Employee9G { get; set; }
        //public DbSet<EmployeeACRID> EmployeeACRID { get; set; }
        //public DbSet<EmployeeAEP> EmployeeAEP { get; set; }
        //public DbSet<EmployeeCED> EmployeeCED { get; set; }
        //public DbSet<EmployeeDependents> EmployeeDependents { get; set; }
        //public DbSet<EmployeeECC> EmployeeECC { get; set; }
        //public DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        //public DbSet<EmployeeMeals> EmployeeMeals { get; set; }
        //public DbSet<EmployeePassport> EmployeePassport { get; set; }
        //public DbSet<EmployeePWP> EmployeePWP { get; set; }
        //public DbSet<EmployeeVisa> EmployeeVisa { get; set; }
        //public DbSet<HomeLeaves> HomeLeaves { get; set; }
        //public DbSet<Locations> Locations { get; set; }
        //public DbSet<ResignationTransactions> ResignationTransactions { get; set; }
        //public DbSet<RFIDs> RFIDs { get; set; }
        //public DbSet<SanctionConfirmations> SanctionConfirmations { get; set; }
        //public DbSet<SanctionTypes> SanctionTypes { get; set; }
        public DbSet<Sites> Sites { get; set; }
        //public DbSet<Transactions> Transactions { get; set; }
        //public DbSet<TransactionTypes> TransactionTypes { get; set; }
        


        #endregion Properties
    }

}
