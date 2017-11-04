using System.ComponentModel;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Staff
    {
        public static Staff ConstructFromDto(StaffDTO dto)
        {
            return new Staff()
            {
                Id = dto.id,
                DateOfBirth = dto.dob,
                FirstName = dto.name_first,
                LastName = dto.name_last,
                FirstNameJapanese = dto.name_first_japanese,
                LastNameJapanese = dto.name_last_japanese,
                ImageUrlLarge = dto.image_url_lge,
                ImageUrlMedium = dto.image_url_med,
                Language = dto.language,
                Role = dto.role
            };
        }
    }
}