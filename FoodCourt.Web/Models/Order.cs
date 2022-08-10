using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FoodCourt.Web.Models
{
    [Table(name: "Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        virtual public int OrderId { get; set; }

        [Required]
        [StringLength(100)]
        virtual public string OrderedFoodName { get; set; }

        [Required]
        [DefaultValue(1)]
        virtual public int OrderedQuantity { get; set; }

        #region Navigation Properties to the Food Model
        virtual public int FoodCategoryId { get; set; }

        [ForeignKey(nameof(Order.FoodCategoryId))]
        public FoodCategory FoodCategory { get; set; }

        #endregion

        #region Navigation Properties to the Order Model
        virtual public int CustomerId { get; set; }

        [ForeignKey(nameof(Order.CustomerId))]
        public Customer Customer { get; set; }

        #endregion

    }
}
