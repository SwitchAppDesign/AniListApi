using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Favourites
    {
        public MediaConnection anime { get; set; }
        public MediaConnection manga { get; set; }
        public CharacterConnection characters { get; set; }
        public StaffConnection staff { get; set; }
        public StudioConnection studios { get; set; }
    }
}
