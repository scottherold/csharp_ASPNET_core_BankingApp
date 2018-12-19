using System.Collections.Generic;
using System.Linq;

namespace BankAccount.Models

{
    public class UserTransactionBundle
    {
        public User user { get; set; }
        public Transaction transaction { get; set; }
        public List<Transaction> transactions { get; set; }

        // Getter only property that sums the transactions
        public decimal Balance
        {
            get
            {
                // Checks to see if the CreatedTransaction list has values
                if(transactions == null)
                {
                    // if the list is null, return 0
                    return 0;
                }
                else
                {
                    // return the sum of the list
                    decimal total = transactions.Sum(transaction => transaction.Amount);
                    return total;
                }
            }
        }
    }
}