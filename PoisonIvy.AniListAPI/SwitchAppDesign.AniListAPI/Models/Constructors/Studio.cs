using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Studio
    {
        public static Studio ConstructFromDto(StudioDTO dto)
        {
            return new Studio()
            {
                Id = dto.id,
                StudioName = dto.studio_name,
                StudioWiki = dto.studio_wiki,
                IsFavourite = dto.favourite,
                MainStudio = dto.main_studio
            };
        }
    }
}
