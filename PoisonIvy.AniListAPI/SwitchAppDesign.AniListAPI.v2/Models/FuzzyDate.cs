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

        public int? year { get; }
        public int? month { get; }
        public int? day { get; }

        public FuzzyDateInt GetFuzzyDateInt()
        {
            return new FuzzyDateInt(int.Parse($"{year}{month}{day}"));
        }

        public string GetFuzzyDateWildcardString()
        {
            return $"{year}{month}{day}%";
        }
    }

    /// <summary>
    /// 8 digit long date integer (YYYYMMDD). Unknown dates represented by 0. E.g. 2016: 20160000, May 1976: 19760500
    /// </summary>
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
