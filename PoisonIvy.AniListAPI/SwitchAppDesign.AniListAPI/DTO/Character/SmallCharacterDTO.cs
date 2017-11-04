using System.Collections.Generic;

namespace PoisonIvy.AniListAPI.DTO
{
    public class SmallCharacterDTO
    {
        public long id { get; set; }
        public string name_first { get; set; }
        public string name_last { get; set; }
        public string image_url_med { get; set; }
        public string image_url_lge { get; set; }
        public string role { get; set; }
        public List<SmallActorDTO> actor { get; set; }
    }
}
