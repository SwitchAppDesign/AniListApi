using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Studio
    {
        public long Id { get; set; }
        public string StudioName { get; set; }
        public string StudioWiki { get; set; }
        public bool IsFavourite { get; set; }
        public string MainStudio { get; set; }
    }
}
