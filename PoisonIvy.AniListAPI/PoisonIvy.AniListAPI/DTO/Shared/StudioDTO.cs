using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.DTO
{
    public  class StudioDTO
    {
        public long id { get; set; }
        public string studio_name { get; set; }
        public string studio_wiki { get; set; }
        public bool favourite { get; set; }
        public string main_studio { get; set; }
    }
}
