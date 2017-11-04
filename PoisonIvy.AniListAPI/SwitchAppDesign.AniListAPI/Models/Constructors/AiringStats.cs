using System;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    partial class AiringStats
    {
        public static AiringStats ConstructFromDto(AiringStatsDTO statsDto)
        {
            return new AiringStats()
            {
                Score = statsDto.score,
                Watching = statsDto.watching
            };
        }
    }
}
