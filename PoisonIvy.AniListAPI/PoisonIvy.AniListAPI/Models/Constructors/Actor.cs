using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    partial class Actor
    {
        public static Actor ConstructFromDto(ActorDTO dto)
        {
            return new Actor()
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
                Role = dto.role,
            };
        }
    }
}
