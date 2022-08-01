
using System.ComponentModel;
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
        [StringLength(100)]
        public string ProductTitle { get; set; }

        [Required]
        [DefaultValue(1)]
        public int NumberOfProducts { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsEnabled { get; set; }
    }
}

