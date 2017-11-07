using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class Media
    {
        public int id { get; set; }
        public int idMal { get; set; }
        public FuzzyDate startDate { get; set; }
        public FuzzyDate endDate { get; set; }
        public string season { get; set; }
        public int seasonYear { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string status { get; set; }
        public int episodes { get; set; }
        public int duration { get; set; }
        public int chapters { get; set; }
        public int volumes { get; set; }
        public bool isAdult { get; set; }
        public string genre { get; set; }
        public string tag { get; set; }
        public string tagCategory { get; set; }
        public bool onList { get; set; }
        public int averageScore { get; set; }
        public int popularity { get; set; }
        public string search { get; set; }
        public int id_not { get; set; }
        public int[] id_in { get; set; }
        public int[] id_not_in { get; set; }
        public int idMal_not { get; set; }
        public int[] idMal_in { get; set; }
        public int[] idMal_not_in { get; set; }
        public FuzzyDate startDate_greater { get; set; }
        public FuzzyDate startDate_lesser { get; set; }
        public string startDate_like { get; set; }
        public FuzzyDate endDate_greater { get; set; }
        public FuzzyDate endDate_lesser { get; set; }
        public string endDate_like { get; set; }
        public int episodes_greater { get; set; }
        public int episodes_lesser { get; set; }
        public int duration_greater { get; set; }
        public int duration_lesser { get; set; }
        public int chapters_greater { get; set; }
        public int chapters_lesser { get; set; }
        public int volumes_greater { get; set; }
        public int volumes_lesser { get; set; }
        public string[] genre_in { get; set; }
        public string[] genre_not_in { get; set; }
        public string[] tag_in { get; set; }
        public string[] tag_not_in { get; set; }
        public string[] tagCategory_in { get; set; }
        public string[] tagCategory_not_in { get; set; }
        public int averageScore_not { get; set; }
        public int averageScore_greater { get; set; }
        public int averageScore_lesser { get; set; }
        public int popularity_not { get; set; }
        public int popularity_greater { get; set; }
        public int popularity_lesser { get; set; }
    }
}
