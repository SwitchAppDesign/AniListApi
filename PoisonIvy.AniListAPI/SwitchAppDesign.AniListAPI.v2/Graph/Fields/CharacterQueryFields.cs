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
    /// All available character query fields.
    /// </summary>
	public class CharacterQueryFields
	{
		internal CharacterQueryFields(AniListQueryType queryType)
		{
			InitializeProperties(queryType);
		}

		/// <summary>
		/// The id of the character
		/// </summary>
		public GraphQueryField IdQueryField()
		{
			return Id;
		}

        /// <summary>
        /// The names of the character
        /// </summary>
        public GraphQueryField NameQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Name)}) requires at least one name query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(NameQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid image name query fields {fields.Where(x => x.ParentClassType != typeof(NameQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Name.GetGraphFieldAndSetFieldArguments(fields);
        }

        /// <summary>
        /// Character images
        /// </summary>
        public GraphQueryField ImageQueryField(IList<GraphQueryField> fields)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Image)}) requires at least one image data query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(ImageDataQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid image data query fields {fields.Where(x => x.ParentClassType != typeof(ImageDataQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    return Image.GetGraphFieldAndSetFieldArguments(fields);
        }

		/// <summary>
		/// A general description of the character
		/// </summary>
		public GraphQueryField DescriptionQueryField()
		{
			return Description;
		}

		/// <summary>
		/// If the character is marked as favourite by the currently authenticated user
		/// </summary>
		public GraphQueryField IsFavouriteQueryField()
		{
			return IsFavourite;
		}

		/// <summary>
		/// The url for the character page on the AniList website
		/// </summary>
		public GraphQueryField SiteUrlQueryField()
		{
			return SiteUrl;
		}

		/// <summary>
		/// Media that includes the character
		/// </summary>
		public GraphQueryField MediaQueryField(IList<GraphQueryField> fields, IList<object> arguments = null)
		{
		    if (fields == null || !fields.Any())
		        throw new GraphQueryFieldInvalidException($"Query field ({nameof(Media)}) requires at least one media connection query field.");

		    if (fields.Any(x => x.ParentClassType != typeof(MediaConnectionQueryFields)))
		        throw new GraphQueryFieldInvalidException($"The following fields are not valid media connection query fields {fields.Where(x => x.ParentClassType != typeof(MediaConnectionQueryFields)).Select(x => x.FieldName).Aggregate((x, y) => $"{x}, {y}")}.");

		    if (arguments != null)
		    {
		        if (arguments.Any(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(MediaConnectionQueryArguments)))
		        {
		            throw new GraphQueryArgumentInvalidException($@"The following fields are not valid query arguments for the field ({Media.GetType().Name}): {
		                arguments
		                    .Where(x => (Type)x.GetType().GetProperty("ParentClassType").GetValue(x) != typeof(MediaConnectionQueryArguments))
		                    .Select(x => nameof(x))
		                    .Aggregate((x, y) => $"{x}, {y}")}.");
		        }

		        foreach (var argument in arguments)
		            argument.IsValidArgumentType();
		    }

		    return Media.GetGraphFieldAndSetFieldArguments(fields, arguments);
        }

		private GraphQueryField Id { get; set; }
		private GraphQueryField Name { get; set; }
		private GraphQueryField Image { get; set; }
		private GraphQueryField Description { get; set; }
		private GraphQueryField IsFavourite { get; set; }
		private GraphQueryField SiteUrl { get; set; }
		private GraphQueryField Media { get; set; }
       
		private void InitializeProperties(AniListQueryType queryType)
		{
			Id = new GraphQueryField("id", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media, AniListQueryType.Page }));
			Name = new GraphQueryField("name", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media, AniListQueryType.Page }));
			Image = new GraphQueryField("image", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media, AniListQueryType.Page }));
			Description = new GraphQueryField("description", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media, AniListQueryType.Page }));
			IsFavourite = new GraphQueryField("isFavourite", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media, AniListQueryType.Page }));
			SiteUrl = new GraphQueryField("siteUrl", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media, AniListQueryType.Page }));
			Media = new GraphQueryField("media", GetType(), queryType, new FieldRules(false, new List<AniListQueryType> { AniListQueryType.Character, AniListQueryType.Media, AniListQueryType.Page }));
		}
	}
}
