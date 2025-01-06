using System.ComponentModel.DataAnnotations;

namespace FloTrack.Models
{
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }
        public string FoodName { get; set; }
        public int Calories { get; set; }
        public int Protein { get; set; }
        public int Carbohydrates { get; set; }
        public int Fats {  get; set; }
        public ICollection<User> Users { get; set; }
    }
}
