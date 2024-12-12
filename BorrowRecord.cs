using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class BorrowRecord
    {
        [Key]
        public int BorrowRecordId { get; set; } //PK
        [Required]
        public int BookId { get; set; } //FK
        [Required(ErrorMessage = "Please enter Borrower Name")]
        public string BorrowerName { get; set; }
        [Required(ErrorMessage = "Please enter Borrower Email Address")]
        [EmailAddress(ErrorMessage = "Please enter a Email Address")]
        public string BorrowerEmail { get; set; }
        [Required(ErrorMessage = "Please enter Borrower Phone Number")]
        [Phone(ErrorMessage = "Please enter a Valid Phone Number")]
        public string Phone { get; set; }
        [BindNever]
        [DataType(DataType.DateTime)]
        public DateTime BorrowDate { get; set; } = DateTime.UtcNow;
        [DataType(DataType.DateTime)]
        public DateTime? ReturnDate { get; set; }
        // Navigation Properties
        [BindNever]
        public Book Book { get; set; }
    }
}

