namespace FloTrack.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public decimal Weight { get; set; }  
        public decimal Height { get; set; }  
        public decimal BodyFatPercentage { get; set; } 
        public decimal ActivityLevel { get; set; }
        public int GoalCalories { get; set; }
    }

}
