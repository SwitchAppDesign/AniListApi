using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchAppDesign.AniListAPI.v2.Models
{
    public class FuzzyDate
    {
        public FuzzyDate(int? year, int? month, int? day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public int? year { get; set; }
        public int? month { get; set; }
        public int? day { get; set; }

        public FuzzyDateInt GetFuzzyDateInt()
        {
            return new FuzzyDateInt(int.Parse($"{year}{month}{day}"));
        }

        public string GetFuzzyDateWildcardString()
        {
            return $"{year}{month}{day}%";
        }
    }

    public class FuzzyDateInt
    {
        public const string FuzzyDateType = "FuzzyDateInt";

        public FuzzyDateInt(int fuzzyDate)
        {
            FuzzyDate = fuzzyDate;
        }

        public int FuzzyDate { get; set; }
    }
}
