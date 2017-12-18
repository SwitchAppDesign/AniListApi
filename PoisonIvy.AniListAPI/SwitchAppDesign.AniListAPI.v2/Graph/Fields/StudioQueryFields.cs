using System;
using SwitchAppDesign.AniListAPI.v2.Types;
using System.Collections.Generic;
using System.Linq;
using SwitchAppDesign.AniListAPI.v2.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Arguments;
using SwitchAppDesign.AniListAPI.v2.Graph.Common;
using SwitchAppDesign.AniListAPI.v2.Graph.Types;
using SwitchAppDesign.AniListAPI.v2.Utility;

namespace SwitchAppDesign.AniListAPI.v2.Graph.Fields
{
    /// <summary>
    /// All Available studio query fields.
    /// </summary>
	public class StudioQueryFields
	{
		internal StudioQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the studio
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

		/// <summary>
		/// The name of the studio
		/// </summary>
		public GraphQueryField NameQueryField()
		{
			return Name;
		}

        /// <summary>
        /// The media the studio has worked on
        /// <param name="fields">The list of media connection fields (found in <see cref="MediaConnectionQueryFields"/>) to be used in the graph query (at least of media connection query field is required).</param>
        /// <param name="arguments">The list of media connection arguments (found in <see cref="MediaConnectionQueryArguments"/>) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed Arguments</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>IsMain:</term><description>If the studio was the primary animation studio of the media.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQueryField MediaQueryField(IList<GraphQueryField> fields, IList<GraphQueryArgument<object>> arguments = null)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Media.GetType().Name}) requires at least one query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid query fields for the field ({Media.GetType().Name}): {fields.Where(x => x.ParentClassType != typeof(MediaConnectionQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(MediaConnectionQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid query arguments for the field ({Media.GetType().Name}): {
		                arguments
		                    .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(MediaConnectionQueryArguments))
		                    .Select(x => x.GetType().Name)
		                    .Aggregate((x, y) => $"{x}, {y}")}.");
		        }

		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

		    return Media.GetGraphFieldAndSetFieldArguments(fields, arguments);
        }

		/// <summary>
		/// The url for the studio page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// If the studio is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }
		private GraphQueryField Media { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField IsFavourite { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			Name = new GraphQueryField("name", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			Media = new GraphQueryField("media", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			SiteUrl = new GraphQueryField("siteUrl", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
			IsFavourite = new GraphQueryField("isFavourite", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Studio }));
		}
	}
}
