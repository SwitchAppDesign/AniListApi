using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class ExternalLink
    {
        public static ExternalLink ConstructFromDto(ExternalLinkDTO dto)
        {
            return new ExternalLink()
            {
                Id = dto.id,
                Url = dto.url,
                Site = dto.site
            };
        }
    }
}
