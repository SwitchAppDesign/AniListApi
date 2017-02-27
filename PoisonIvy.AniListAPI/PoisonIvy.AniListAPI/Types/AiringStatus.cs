using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Types
{
    public enum AiringStatus
    {
        [Description("Not Found")]
        NotFound = -1,
        [Description("finished airing")]
        FinishedAiring = 0,
        [Description("currently airing")]
        CurrentlyAiring = 1,
        [Description("not yet aired")]
        NotYetAired = 2,
        [Description("cancelled")]
        Cancelled = 3,
        [Description("finished publishing")]
        FinishedPublishing = 4,
        [Description("publishing")]
        Publishing = 5,
        [Description("not yet published")]
        NotYetPublished = 6,
    }
}
