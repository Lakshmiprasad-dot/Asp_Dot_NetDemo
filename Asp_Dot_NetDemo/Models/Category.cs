using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asp_Dot_NetDemo.Models
{
    [Table(name:"Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Required]
        [Column(TypeName ="varchar(50)")]
        public string CategoryName { get; set; }

        #region Navigation Properties to the Book Model

        public ICollection<Book> Books { get; set; }

        #endregion
    }
}
