using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All available media title query fields.
    /// </summary>
    public class MediaTitleQueryFields
	{
		internal MediaTitleQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The romanization of the native language title
		/// </summary>
		public GraphQueryField RomajiQueryField()
		{
			return Romaji;
		}

	    /// <summary>
	    /// Defines whether the romaji title is stylised.
	    /// </summary>
        public GraphQueryField IsRomajiStylisedQueryField()
		{
			return IsRomajiStylised;
		}

		/// <summary>
		/// The official english title
		/// </summary>
		public GraphQueryField EnglishQueryField()
		{
			return English;
		}

	    /// <summary>
	    /// Defines whether the english title is stylised.
	    /// </summary>
        public GraphQueryField IsEnglishStylisedQueryField()
		{
			return IsEnglishStylised;
		}

		/// <summary>
		/// Official title in it's native language
		/// </summary>
		public GraphQueryField NativeQueryField()
		{
			return Native;
		}

	    /// <summary>
	    /// Defines whether the native title is stylised.
	    /// </summary>
        public GraphQueryField IsNativeStylisedQueryField()
		{
			return IsNativeStylised;
		}

		/// <summary>
		/// The currently authenticated users preferred title language. Default romaji for non-authenticaed
		/// </summary>
		public GraphQueryField UserPreferredQueryField()
		{
			return UserPreferred;
		}

		private GraphQueryField Romaji { get; set; }
		private GraphQueryField IsRomajiStylised { get; set; }
		private GraphQueryField English { get; set; }
		private GraphQueryField IsEnglishStylised { get; set; }
		private GraphQueryField Native { get; set; }
		private GraphQueryField IsNativeStylised { get; set; }
		private GraphQueryField UserPreferred { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Romaji = new GraphQueryField("romaji", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsRomajiStylised = new GraphQueryField("IsRomajiStylised", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			English = new GraphQueryField("english", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsEnglishStylised = new GraphQueryField("IsEnglishStylised", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Native = new GraphQueryField("native", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			IsNativeStylised = new GraphQueryField("IsNativeStylised", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			UserPreferred = new GraphQueryField("userPreferred", queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
