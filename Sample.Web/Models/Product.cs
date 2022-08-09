using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    
namespace Sample.Web.Models
{
    [Table(name:"Products")]
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
        [DefaultValue(0)]
        public decimal Price { get; set; }

        [Required]

        public DateTime ManufacturingDate { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsEnabled { get; set; }

        #region Navigation Properties to the Category Model
        virtual public int CategoryId { get; set; }

        [ForeignKey(nameof(Product.CategoryId))]
        public Category Category { get; set; }

        #endregion

    }
}
