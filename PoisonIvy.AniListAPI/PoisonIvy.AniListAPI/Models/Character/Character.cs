using System.Collections.Generic;
using PoisonIvy.AniListAPI.DTO;

namespace PoisonIvy.AniListAPI.Models
{
    public partial class Character
    {
        public long Id { get; set; }
        public string AltName { get; set; }
        public string Info { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JapaneseName { get; set; }
        public string ImageUrlLarge { get; set; }
        public string ImageUrlMedium { get; set; }
        public string ActorId { get; set; }
        public string Role { get; set; }
        public List<BasicActor> Actors { get; set; }
    }
}
