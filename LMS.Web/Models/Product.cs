
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LMS.Web.Models
{
    [Table(name: "Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        virtual public int ProductId { get; set; }


        [Required]
        [StringLength(100)]
        virtual public string ProductTitle { get; set; }

        [Required]
        [DefaultValue(1)]
        virtual public int NumberOfCopies { get; set; }

        [Required]
        [DefaultValue(false)]
        virtual public bool IsEnabled { get; set; }


        #region Navigation Properties to the Category Model
        virtual public int CategoryId { get; set; }

        [ForeignKey(nameof(Product.CategoryId))]
        public Category Category { get; set; }

        #endregion

    }
}

