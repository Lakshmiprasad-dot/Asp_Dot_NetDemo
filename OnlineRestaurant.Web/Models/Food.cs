using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace OnlineRestaurant.Web.Models
{
    [Table(name: "Foods")]
    public class Food
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        virtual public int FoodId { get; set; }

        [Required]
        [StringLength(100)]
        virtual public string FoodName { get; set; }

        [Required]
        [DefaultValue(1)]
        virtual public int Quantity { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [DefaultValue(false)]
        virtual public bool IsEnabled { get; set; }

        #region Navigation Properties to the Category Model
        virtual public int FoodCategoryId { get; set; }

        [ForeignKey(nameof(Food.FoodCategoryId))]
        public FoodCategory FoodCategory { get; set; }

        #endregion
    }
}
