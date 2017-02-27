using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.DTO
{
    public class TagDTO
    {
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool spoiler { get; set; }
        public bool adult { get; set; }
        public bool demographic { get; set; }
        public int denied { get; set; }
        public string category { get; set; }
        public int votes { get; set; }
        public bool series_spoiler { get; set; }
    }
}
