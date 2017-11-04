using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class ExternalLink
    {
        public long Id { get; set; }
        public string Url { get; set; }
        public string Site { get; set; }
    }
}
