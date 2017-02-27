using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Tag
    {
        public static Tag ConstructFromDto(TagDTO dto)
        {
            return new Tag()
            {
                Id = dto.id,
                Name = dto.name,
                Description = dto.description,
                IsSpoiler = dto.spoiler,
                IsAdult = dto.adult,
                IsDemographic = dto.demographic,
                Denied = dto.denied,
                Category = dto.category,
                Votes = dto.votes,
                IsSeriesSpoiler = dto.series_spoiler
            };
        }
    }
}
