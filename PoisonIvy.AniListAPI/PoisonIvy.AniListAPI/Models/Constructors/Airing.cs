using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    partial class Airing
    {
        public static Airing ConstructFromDto(AiringDTO dto)
        {
            return new Airing()
            {
                Time = dto.time,
                Countdown = dto.countdown,
                NextEpisode = dto.next_episode
            };
        }
    }
}
