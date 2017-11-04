using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.DTO
{
    public class RankingDTO
    {
        public long id { get; set; }
        public int rank { get; set; }
        public int type { get; set; }
        public string type_string { get; set; }
        public string ranking_type { get; set; }
        public string format { get; set; }
        public string year { get; set; }
        public string season { get; set; }
    }
}
