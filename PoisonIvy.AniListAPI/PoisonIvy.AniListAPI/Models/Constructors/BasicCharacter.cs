using System.Collections.Generic;
using System.Linq;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class BasicCharacter
    {
        public static BasicCharacter ConstructFromDto(SmallCharacterDTO dto)
        {
            return new BasicCharacter()
            {
                Id = dto.id,
                FirstName = dto.name_first,
                LastName = dto.name_last,
                ImageUrlLarge = dto.image_url_lge,
                ImageUrlMedium = dto.image_url_med,
                Role = dto.role,
                Actors = dto.actor?.Select(BasicActor.ConstructFromDto).ToList()
            };
        }    
    }
}
