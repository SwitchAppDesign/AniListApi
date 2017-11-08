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

        private int? year { get; }
        private int? month { get; }
        private int? day { get; }

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
