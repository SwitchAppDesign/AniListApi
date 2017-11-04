using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Ranking
    {
        public long Id { get; set; }
        public int Rank { get; set; }
        public int Type { get; set; }
        public string TypeDescription { get; set; }
        public string RankingType { get; set; }
        public string Format { get; set; }
        public string Year { get; set; }
        public string Season { get; set; }
    }
}
