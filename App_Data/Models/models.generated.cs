//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "a403af025b3ec601")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.2")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Blog Post</summary>
	[PublishedContentModel("BlogPost")]
	public partial class BlogPost : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BlogPost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Introduction
		///</summary>
		[ImplementPropertyType("introduction")]
		public string Introduction
		{
			get { return this.GetPropertyValue<string>("introduction"); }
		}
	}

	/// <summary>Blog Post Repository</summary>
	[PublishedContentModel("BlogPostRepository")]
	public partial class BlogPostRepository : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "BlogPostRepository";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogPostRepository(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogPostRepository, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in bottom navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("Home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Site Description
		///</summary>
		[ImplementPropertyType("siteDescription")]
		public string SiteDescription
		{
			get { return this.GetPropertyValue<string>("siteDescription"); }
		}

		///<summary>
		/// Site Logo
		///</summary>
		[ImplementPropertyType("siteLogo")]
		public string SiteLogo
		{
			get { return this.GetPropertyValue<string>("siteLogo"); }
		}

		///<summary>
		/// Site Title
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return this.GetPropertyValue<string>("siteTitle"); }
		}
	}

	/// <summary>Landing Page</summary>
	[PublishedContentModel("LandingPage")]
	public partial class LandingPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "LandingPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LandingPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LandingPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Hide in bottom navigation?
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return this.GetPropertyValue<bool>("umbracoNaviHide"); }
		}
	}

	/// <summary>Text Page</summary>
	[PublishedContentModel("TextPage")]
	public partial class TextPage : PublishedContentModel, IMasterDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "TextPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TextPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}
	}

	// Mixin content Type 1085 with alias "masterDocType"
	/// <summary>Master Doc Type</summary>
	public partial interface IMasterDocType : IPublishedContent
	{
	}

	/// <summary>Master Doc Type</summary>
	[PublishedContentModel("masterDocType")]
	public partial class MasterDocType : PublishedContentModel, IMasterDocType
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "masterDocType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MasterDocType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MasterDocType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Art</summary>
	[PublishedContentModel("portfolioStyle1")]
	public partial class PortfolioStyle1 : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolioStyle1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PortfolioStyle1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PortfolioStyle1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Availability: Is this sold?
		///</summary>
		[ImplementPropertyType("availability")]
		public string Availability
		{
			get { return this.GetPropertyValue<string>("availability"); }
		}

		///<summary>
		/// Category
		///</summary>
		[ImplementPropertyType("category")]
		public string Category
		{
			get { return this.GetPropertyValue<string>("category"); }
		}

		///<summary>
		/// Description: Description of the artwork
		///</summary>
		[ImplementPropertyType("description")]
		public string Description
		{
			get { return this.GetPropertyValue<string>("description"); }
		}

		///<summary>
		/// Feature on home page: Should this show on the home page? Note, 4 is the ideal number of photos to show on the home page.
		///</summary>
		[ImplementPropertyType("featureOnHomePage")]
		public bool FeatureOnHomePage
		{
			get { return this.GetPropertyValue<bool>("featureOnHomePage"); }
		}

		///<summary>
		/// Main Image: Select image to display
		///</summary>
		[ImplementPropertyType("image")]
		public IPublishedContent Image
		{
			get { return this.GetPropertyValue<IPublishedContent>("image"); }
		}

		///<summary>
		/// Media: What media was used?
		///</summary>
		[ImplementPropertyType("media")]
		public string Media
		{
			get { return this.GetPropertyValue<string>("media"); }
		}

		///<summary>
		/// New?: Do you want to feature this painting as new?
		///</summary>
		[ImplementPropertyType("new")]
		public bool New
		{
			get { return this.GetPropertyValue<bool>("new"); }
		}

		///<summary>
		/// On display at: If this painting is currently on display, list the name of the venue.
		///</summary>
		[ImplementPropertyType("onDisplayAt")]
		public string OnDisplayAt
		{
			get { return this.GetPropertyValue<string>("onDisplayAt"); }
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("size")]
		public string Size
		{
			get { return this.GetPropertyValue<string>("size"); }
		}

		///<summary>
		/// Title: The title of the image.
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Portfolio Page - Style 1</summary>
	[PublishedContentModel("portfolioPageStyle1")]
	public partial class PortfolioPageStyle1 : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolioPageStyle1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PortfolioPageStyle1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PortfolioPageStyle1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Title: Page title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}
	}

	/// <summary>Home - Style 2</summary>
	[PublishedContentModel("Home1")]
	public partial class Home1 : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Home1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public Newtonsoft.Json.Linq.JToken Content
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("content"); }
		}

		///<summary>
		/// Featured Portfolio: Which portfolio page should be featured on the home page via the "view portfolio" link?
		///</summary>
		[ImplementPropertyType("featuredPortfolio")]
		public IPublishedContent FeaturedPortfolio
		{
			get { return this.GetPropertyValue<IPublishedContent>("featuredPortfolio"); }
		}

		///<summary>
		/// Site Description
		///</summary>
		[ImplementPropertyType("siteDescription")]
		public string SiteDescription
		{
			get { return this.GetPropertyValue<string>("siteDescription"); }
		}

		///<summary>
		/// Site Title
		///</summary>
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle
		{
			get { return this.GetPropertyValue<string>("siteTitle"); }
		}

		///<summary>
		/// Small image 1: The top image on the right of the Main Image
		///</summary>
		[ImplementPropertyType("smallImage1")]
		public IPublishedContent SmallImage1
		{
			get { return this.GetPropertyValue<IPublishedContent>("smallImage1"); }
		}

		///<summary>
		/// Small image 2: The second image on the right of the Main Image
		///</summary>
		[ImplementPropertyType("smallImage2")]
		public IPublishedContent SmallImage2
		{
			get { return this.GetPropertyValue<IPublishedContent>("smallImage2"); }
		}

		///<summary>
		/// Small image 3: The third image on the right of the Main Image
		///</summary>
		[ImplementPropertyType("smallImage3")]
		public IPublishedContent SmallImage3
		{
			get { return this.GetPropertyValue<IPublishedContent>("smallImage3"); }
		}

		///<summary>
		/// Small image 4: The bottom image on the right of the Main Image
		///</summary>
		[ImplementPropertyType("smallImage4")]
		public IPublishedContent SmallImage4
		{
			get { return this.GetPropertyValue<IPublishedContent>("smallImage4"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
