using System.Collections.Generic;

namespace PoisonIvy.AniListAPI.DTO
{
    public class CharacterDTO
    {
       public string name_alt { get; set; }
       public string info { get; set; }
       public long id { get; set; }
       public string name_first { get; set; }
       public string name_last { get; set; }
       public string name_japanese { get; set; }
       public string image_url_lge { get; set; }
       public string image_url_med { get; set; }
       public string id_actor { get; set; }
       public string role { get; set; }
       public List<SmallActorDTO> actor { get; set; }
    }
}
