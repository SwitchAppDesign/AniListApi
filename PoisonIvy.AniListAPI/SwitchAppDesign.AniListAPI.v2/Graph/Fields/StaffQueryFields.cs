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
    /// All available staff query fields.
    /// </summary>
	public class StaffQueryFields
	{
		internal StaffQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the staff member
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

        /// <summary>
        /// The names of the staff member
        /// <param name="fields">The list of name query fields (found in <see cref="NameQueryFields"/>) to be used in the graph query (at least of name query field is required. Alernative field is not allowed).</param>
        /// </summary>
        public GraphQueryField NameQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Name.GetType().Name}) requires at least one name query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(NameQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid name query fields {fields.Where(x => x.ParentClassType != typeof(NameQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Name.GetGraphFieldAndSetFieldArguments(fields);
        }

		/// <summary>
		/// The primary language of the staff member
		/// </summary>
		public GraphQueryField LanguageQueryField()
		{
			return Language;
		}

        /// <summary>
        /// The staff images
        /// <param name="fields">The list of image data fields (found in <see cref="ImageDataQueryFields"/>) to be used in the graph query (at least of image data query field is required).</param>
        /// </summary>
        public GraphQueryField ImageQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Image.GetType().Name}) requires at least one image data query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(ImageDataQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid image data query fields {fields.Where(x => x.ParentClassType != typeof(ImageDataQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Image.GetGraphFieldAndSetFieldArguments(fields);
        }

		/// <summary>
		/// A general description of the staff member
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// If the staff member is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// The url for the staff page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

        /// <summary>
        /// Media where the staff member has a production role
        /// <param name="fields">The list of media connection fields (found in <see cref="MediaConnectionQueryFields"/>) to be used in the graph query (at least of media connection query field is required).</param>
        /// <param name="arguments">The list of media connection arguments (found in <see cref="MediaConnectionQueryArguments"/>) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed params</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQueryField StaffMediaQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({StaffMedia.GetType().Name}) requires at least one media connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media connection query fields {fields.Where(x => x.ParentClassType != typeof(MediaConnectionQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(MediaConnectionQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid media connection query arguments {
		                arguments
		                    .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(MediaConnectionQueryArguments))
		                    .Select(x => x.GetType().Name)
		                    .Aggregate((x, y) => $"{x}, {y}")}.");
		        }

		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

		    return StaffMedia.GetGraphFieldAndSetFieldArguments(fields, arguments);
        }

        /// <summary>
        /// Characters voiced by the actor
        /// <param name="fields">The list of character connection fields (found in <see cref="CharacterConnectionQueryFields"/>) to be used in the graph query (at least of character connection query field is required).</param>
        /// <param name="arguments">The list of character connection arguments (found in <see cref="CharacterConnectionQueryArguments"/>) to be used in the graph query.</param>
        /// <list type="bullet">
        /// <listheader><term>Allowed params</term><description>(Optional)</description></listheader>
        /// <item><term>Sort:</term><description>The fields to sort by.</description></item>
        /// <item><term>Page:</term><description>The page.</description></item>
        /// <item><term>PerPage:</term><description>The amount of entries per page, max 25.</description></item>
        /// </list>
        /// </summary>
        public GraphQueryField CharactersQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({Characters.GetType().Name}) requires at least one character connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(CharacterConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid character connection query fields {fields.Where(x => x.ParentClassType != typeof(CharacterConnectionQueryFields)).Select(x => x.GetType().Name).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(CharacterConnectionQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid character connection query arguments {
		                arguments
		                    .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(CharacterConnectionQueryArguments))
		                    .Select(x => x.GetType().Name)
		                    .Aggregate((x, y) => $"{x}, {y}")}.");
		        }

		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

		    return Characters.GetGraphFieldAndSetFieldArguments(fields, arguments);
        }

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }
		private GraphQueryField Language { get; set; }
		private GraphQueryField Image { get; set; }
		private GraphQueryField Description { get; set; }
		private GraphQueryField IsFavourite { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField StaffMedia { get; set; }
		private GraphQueryField Characters { get; set; }

		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Name = new GraphQueryField("name", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Language = new GraphQueryField("language", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Image = new GraphQueryField("image", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Description = new GraphQueryField("description", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			IsFavourite = new GraphQueryField("isFavourite", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			SiteUrl = new GraphQueryField("siteUrl", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			StaffMedia = new GraphQueryField("staffMedia", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
			Characters = new GraphQueryField("characters", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Staff }));
		}
	}
}
