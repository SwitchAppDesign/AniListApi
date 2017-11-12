using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
	internal class MediaTitleQueryFields
	{
		public MediaTitleQueryFields()
		{
			InitializeProperties();
		}

		/// <summary>
		/// The romanization of the native language title
		/// </summary>
		public GraphQLQueryField RomajiQueryField()
		{
			return Romaji;
		}

		public GraphQLQueryField IsRomajiStylisedQueryField()
		{
			return IsRomajiStylised;
		}

		/// <summary>
		/// The official english title
		/// </summary>
		public GraphQLQueryField EnglishQueryField()
		{
			return English;
		}

		public GraphQLQueryField IsEnglishStylisedQueryField()
		{
			return IsEnglishStylised;
		}

		/// <summary>
		/// Official title in it's native language
		/// </summary>
		public GraphQLQueryField NativeQueryField()
		{
			return Native;
		}

		public GraphQLQueryField IsNativeStylisedQueryField()
		{
			return IsNativeStylised;
		}

		/// <summary>
		/// The currently authenticated users preferred title language. Default romaji for non-authenticaed
		/// </summary>
		public GraphQLQueryField UserPreferredQueryField()
		{
			return UserPreferred;
		}

		private GraphQLQueryField Romaji { get; set; }
		private GraphQLQueryField IsRomajiStylised { get; set; }
		private GraphQLQueryField English { get; set; }
		private GraphQLQueryField IsEnglishStylised { get; set; }
		private GraphQLQueryField Native { get; set; }
		private GraphQLQueryField IsNativeStylised { get; set; }
		private GraphQLQueryField UserPreferred { get; set; }

		private void InitializeProperties()
		{
			Romaji = new GraphQLQueryField("romaji", new FieldRules(false));
			IsRomajiStylised = new GraphQLQueryField("IsRomajiStylised", new FieldRules(false));
			English = new GraphQLQueryField("english", new FieldRules(false));
			IsEnglishStylised = new GraphQLQueryField("IsEnglishStylised", new FieldRules(false));
			Native = new GraphQLQueryField("native", new FieldRules(false));
			IsNativeStylised = new GraphQLQueryField("IsNativeStylised", new FieldRules(false));
			UserPreferred = new GraphQLQueryField("userPreferred", new FieldRules(false));
		}
	}
}
