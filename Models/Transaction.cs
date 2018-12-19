using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankAccount.Models
{
    // Model used for registration. Sanatizes data for the controller to send to the DB.
    public class Transaction
    {
        // Key sets the PK in the DB
        [Key]
        public int TransactionId { get; set; }
        
        // For transaction
        [Display(Name="Transaction Amount")]
        [Required(ErrorMessage="Please enter a transaction amount!")]
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }

        // Foreign key reference
        public int UserId { get; set; }

        // Reference to the User class that the PK is linked
        public User Creator { get; set; }
    }
}