using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Types
{
    public enum Seasons
    {
        [Description("Not Found")]
        NotFound = -1,
        [Description("Spring")]
        Spring = 3,
        [Description("Summer")]
        Summer = 6,
        [Description("Fall")]
        Fall = 9,
        [Description("Winter")]
        Winter = 12
    }
}
