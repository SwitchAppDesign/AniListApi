using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Ranking
    {
        public static Ranking ConstructFromDto(RankingDTO dto)
        {
            return new Ranking()
            {
                Id = dto.id,
                Rank = dto.rank,
                Type = dto.type,
                TypeDescription = dto.type_string,
                RankingType = dto.ranking_type,
                Format = dto.format,
                Year = dto.year,
                Season = dto.season
            };
        }
    }
}
