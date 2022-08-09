
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Asp_Dot_NetDemo.Models
{
    [Table(name: "Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50)]
        public string ProductName { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductTitle { get; set; }
        public int CategoryId { get; set; }

        #region

        [ForeignKey(nameof(Product.CategoryId))]
        public Category Category { get; set; }
        #endregion
    }
}