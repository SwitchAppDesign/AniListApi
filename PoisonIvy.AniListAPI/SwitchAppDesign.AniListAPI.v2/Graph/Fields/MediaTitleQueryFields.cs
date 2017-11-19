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
		/// The official english title
		/// </summary>
		public GraphQueryField EnglishQueryField()
		{
			return English;
		}

		/// <summary>
		/// Official title in it's native language
		/// </summary>
		public GraphQueryField NativeQueryField()
		{
			return Native;
		}

		/// <summary>
		/// The currently authenticated users preferred title language. Default romaji for non-authenticaed
		/// </summary>
		public GraphQueryField UserPreferredQueryField()
		{
			return UserPreferred;
		}

		private GraphQueryField Romaji { get; set; }
		private GraphQueryField English { get; set; }
		private GraphQueryField Native { get; set; }
		private GraphQueryField UserPreferred { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Romaji = new GraphQueryField("romaji", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			English = new GraphQueryField("english", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			Native = new GraphQueryField("native", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
			UserPreferred = new GraphQueryField("userPreferred", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Media }));
		}
	}
}
