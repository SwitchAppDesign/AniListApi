using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.DTO
{
    public class SmallActorDTO
    {
        public long id { get; set; }
        public string name_first { get; set; }
        public string name_last { get; set; }
        public string language { get; set; }
        public string image_url_lge { get; set; }
        public string image_url_med { get; set; }
        public string role { get; set; }
    }
}
