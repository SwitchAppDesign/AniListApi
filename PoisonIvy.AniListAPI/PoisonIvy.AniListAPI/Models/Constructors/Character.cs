using System.Linq;
using PoisonIvy.AniListAPI.DTO;
using PoisonIvy.AniListAPI.Helpers;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Character
    {
        public static Character ConstructFromDto(CharacterDTO dto)
        {
            return new Character()
            {
                Id = dto.id,
                AltName = dto.name_alt,
                Info = dto.info,
                FirstName = dto.name_first,
                LastName = dto.name_last,
                JapaneseName = dto.name_japanese,
                ImageUrlLarge = dto.image_url_lge,
                ImageUrlMedium = dto.image_url_med,
                ActorId = dto.id_actor,
                Role = dto.role,
                Actors = dto.actor?.Select(BasicActor.ConstructFromDto).ToList()
            };
        }   
    }
}
