using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class BasicStaff
    {
        public static BasicStaff ConstructFromDto(SmallStaffDTO dto)
        {
            return new BasicStaff()
            {
                Id = dto.id,
                FirstName = dto.name_first,
                LastName = dto.name_last,
                Language = dto.language,
                ImageUrlLarge = dto.image_url_lge,
                ImageUrlMedium = dto.image_url_med,
                Role = dto.role
            };
        }
    }
}