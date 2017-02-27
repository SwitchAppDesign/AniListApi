using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    partial class BasicActor
    {
        public static BasicActor ConstructFromDto(SmallActorDTO dto)
        {
            return new BasicActor()
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
