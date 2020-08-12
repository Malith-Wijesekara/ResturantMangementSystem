using System.ComponentModel.DataAnnotations;

namespace MyTasteApp.Models
{
    public class FoodType
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Display(Name = "Food Type")]
        public string Name { get; set; }
    }
}