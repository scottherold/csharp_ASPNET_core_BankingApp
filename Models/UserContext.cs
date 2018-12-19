using Microsoft.EntityFrameworkCore;

namespace BankAccount.Models
{
    public class UserContext : DbContext
    {
        // Creates the Usercontext object ot use for querying
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        // Creates a list of queried data
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}