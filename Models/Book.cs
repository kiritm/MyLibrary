using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyLibrary.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Book Title {0} is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be minimum 3 characters and a maximum of 100 characters")]
        public string  BookTitle { get; set; }
      
        [Column(TypeName = "nvarchar(20)")]      
        public string BookEdition { get; set; }
      
        [Column(TypeName = "nvarchar(50)")]      
        public string BookAuthor1 { get; set; }
       
        [Column(TypeName = "nvarchar(50)")]     
        public string BookAuthor2 { get; set; }

        [Column(TypeName = "nvarchar(50)")]     
        public string BookCategory { get; set; }

        [Column(TypeName = "decimal(6,2)")]
        [Range(0, 999999.99, ErrorMessage = "Invalid Target Price; Max 6 digits")]
        public decimal BookPurchasePrice { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string BookPublisher { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string BookISBN { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string BookStatus { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string BookStorage_Code { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string BookStorage_Type { get; set; }
     
    }
}
