using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonIvy.AniListAPI.Types
{
    public enum RelationType
    {
        None = -1,
        [Description("Sequel")]
        Sequel = 0,
        [Description("Prequel")]
        Prequel = 1
    }
}
