using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.DTO
{
    public class AiringDTO
    {
        public DateTime? time { get; set; }
        public long countdown { get; set; }
        public int next_episode { get; set; }
    }
}
