using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Staff
    {
        public long Id { get; set; }
        public int DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstNameJapanese { get; set; }
        public string LastNameJapanese { get; set; }
        public string ImageUrlLarge { get; set; }
        public string ImageUrlMedium { get; set; }
        public string Language { get; set; }
        public string Role { get; set; }

    }
}