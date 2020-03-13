using System.Linq;

namespace Models
{
	public class Post : Base.Entity
	{

		#region Configuration
		/// <summary>
		/// Regulate One to many relation between Users and Posts
		/// With Fluent Api Approach
		/// </summary>
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Post>
		{
			public Configuration() : base()
			{
				HasRequired(current => current.WriterUser)
					.WithMany(user => user.WrittenPosts)
					.HasForeignKey(current => current.WriterUserId)
					.WillCascadeOnDelete(false);

				HasOptional(current => current.VerifierUser)
					.WithMany(user => user.VerifiedPosts)
					.HasForeignKey(current => current.VerifierUserId)
					.WillCascadeOnDelete(false);

				HasRequired(current => current.PostCategory)
					.WithMany(postCategory => postCategory.Posts)
					.HasForeignKey(current => current.PostCategoryId)
					.WillCascadeOnDelete(false);
			}
		}
		#endregion/Configuration

		public Post() : base()
		{
		}


		// **********
		/// <summary>
		/// توضیحات
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Description))]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 65)]

		public string Description { get; set; }
		// **********


		// **********
		/// <summary>
		/// رمز عبور
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Password))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 20, MinimumLength = 8)]

		public string Password { get; set; }
		// **********

		// **********
		/// <summary>
		/// User who creates or writes the post (One to many relation between Users and Posts from Object-Oriented View).
		/// </summary>
		public virtual User WriterUser { get; set; }
		// **********

		// **********
		/// <summary>
		/// UserId (FK) who creates or writes the post (One to many relation between Users and Posts from Database View).
		/// </summary>
		public System.Guid WriterUserId { get; set; }
		// **********

		// **********
		/// <summary>
		/// User who verifies the post (One to many relation from Object-Oriented View).
		/// </summary>
		public virtual User VerifierUser { get; set; }
		// **********

		// **********
		/// <summary>
		/// UserId (FK) who verifies the post (One to many relation from Database View).
		/// </summary>
		public System.Guid? VerifierUserId { get; set; }
		// **********

		// **********
		/// <summary>
		/// PostCategory for each post (One to many relation from Object-Oriented View).
		/// </summary>
		public virtual PostCategory PostCategory { get; set; }
		// **********

		// **********
		/// <summary>
		/// PostCategoryId (FK) for each post (One to many relation from Database View).
		/// </summary>
		public System.Guid? PostCategoryId { get; set; }
		// **********

		// **********
		/// <summary>
		/// نوع پست 
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.PostTypeId))]

		public System.Guid PostTypeId { get; set; }
		// **********

		// **********
		/// <summary>
		/// آیدی طرح 
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.LayoutId))]

		public System.Guid LayoutId { get; set; }
		// **********

		// **********
		/// <summary>
		/// ویژه بودن پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsFeatured))]

		public bool IsFeatured { get; set; }
		// **********

		// **********
		/// <summary>
		/// فعال بودن اظهار نظر پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsCommentingEnabled))]

		public bool IsCommentingEnabled { get; set; }
		// **********

		// **********
		/// <summary>
		/// پیش نویس شدن متن پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsDraft))]

		public bool IsDraft { get; set; }
		// **********

		// **********
		/// <summary>
		/// پیوست داشتن
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.HasAttachment))]

		public bool HasAttachment { get; set; }
		// **********

		// **********
		/// <summary>
		///  پسوند پیوست
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 5)]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.AttachmentExtension))]

		public string AttachmentExtension { get; set; }
		// **********

		// **********
		/// <summary>
		///  طول پیوست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.AttachmentLength))]

		public long AttachmentLength { get; set; }
		// **********

		// **********
		/// <summary>
		///  تعداد دانلود پیوست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.DownloadCount))]

		public int DownloadCount { get; set; }
		// **********

		// **********
		/// <summary>
		///  مقدمه
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Introduction))]

		public string Introduction { get; set; }
		// **********

		// **********
		/// <summary>
		///  آدرس تصویر
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ImageUrl))]

		public string ImageUrl { get; set; }
		// **********

		// **********
		/// <summary>
		/// بدنه
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Body))]

		public string Body { get; set; }
		// **********

		// **********
		/// <summary>
		///  نمایش کاربر خالق پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.DisplayCreatorUser))]

		public bool DisplayCreatorUser { get; set; }
		// **********

		// **********
		/// <summary>
		/// تعداد بازدید
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Hits))]

		public int Hits { get; set; }
		// **********

		// **********
		/// <summary>
		/// آیا موتورهای جستجو آن را فهرست می کنند؟
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.DoesSearchEnginesIndexIt))]

		public bool DoesSearchEnginesIndexIt { get; set; }
		// **********

		// **********
		/// <summary>
		/// آیا موتورهای جستجو از آن پیروی می کنند؟
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.DoesSearchEnginesFollowIt))]

		public bool DoesSearchEnginesFollowIt { get; set; }
		// **********

		// **********
		/// <summary>
		/// عنوان پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredValidationErrorMessage))]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 65)]

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Title))]

		public string Title { get; set; }
		// **********

		// **********
		/// <summary>
		/// نویسنده پست
		/// </summary>

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Author))]

		public string Author { get; set; }
		// **********

		// **********
		/// <summary>
		/// کلیدواژه ها
		/// </summary>

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Keywords))]

		public string Keywords { get; set; }
		// **********

		// **********
		/// <summary>
		/// طبقه بندی
		/// </summary>

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Classification))]

		public string Classification { get; set; }
		// **********

		// **********
		/// <summary>
		/// حق نشر
		/// </summary>

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Copyright))]

		public string Copyright { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان شروع انتشار
		/// </summary>

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.PublishStartDateTime))]

		public System.DateTime? PublishStartDateTime { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان پایان انتشار
		/// </summary>

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.PublishFinishDateTime))]

		public System.DateTime? PublishFinishDateTime { get; set; }
		// **********

		// **********
		/// <summary>
		/// 
		/// </summary>

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsSystem))]

		public bool IsSystem { get; set; }
		// **********

		// **********
		/// <summary>
		/// مرتب سازی
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Ordering))]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false, IsClustered = false)]
		public int Ordering { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان درج پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.InsertDateTime))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredValidationErrorMessage))]
		public System.DateTime InsertDateTime { get; set; }
		// **********

		// **********
		/// <summary>
		/// آیدی کاربر سازنده پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.CreatorUserId))]

		public System.Guid CreatorUserId { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان به روزرسانی پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.UpdateDateTime))]

		public System.DateTime UpdateDateTime { get; set; }
		// **********

		// **********
		/// <summary>
		/// فعال بودن پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsActive))]

		public bool IsActive { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان تایید پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.VerifyDateTime))]

		public System.DateTime VerifyDateTime { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان حذف پست
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.DeleteDateTime))]

		public System.DateTime? DeleteDateTime { get; set; }
		// **********
		
		// **********
		/// <summary>
		/// آیا پست مورد نظر حذف شده است؟
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsDeleted))]

		public bool IsDeleted { get; set; }
		// **********

		// **********
		/// <summary>
		/// حذف کاربر با آیدی مورد نظر.
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.RemoverUserId))]

		public System.Guid RemoverUserId { get; set; }
		// **********

	}

}
