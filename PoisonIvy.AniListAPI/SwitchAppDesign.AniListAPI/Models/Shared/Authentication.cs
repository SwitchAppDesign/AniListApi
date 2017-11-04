namespace PoisonIvy.AniListAPI.Models
{
   public class Authentication
    {
       public string access_token { get; set; }

       public string token_type { get; set; }

       public string expires { get; set; }

       public string expires_in { get; set; }
    }
}
