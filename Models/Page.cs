namespace Models
{
	public class Page : Base.Entity
	{
		public Page() : base()
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
		/// طرح زمینه صفحه 
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.LayoutId))]

		public System.Guid LayoutId { get; set; }
		// **********

		// **********
		/// <summary>
		/// ویژه بودن صفحه
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsFeatured))]

		public bool IsFeatured { get; set; }
		// **********

		// **********
		/// <summary>
		/// فعال بودن اظهار نظر در صفحه
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsCommentingEnabled))]

		public bool IsCommentingEnabled { get; set; }
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
		/// تعداد دانلود 
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
		///  نمایش کاربر خالق صفحه
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
		/// عنوان صفحه
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
		/// نویسنده مطالب صفحه
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
		/// تاریخ و زمان درج صفحه
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
		/// آیدی کاربر سازنده صفحه
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.CreatorUserId))]

		public System.Guid CreatorUserId { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان به روزرسانی صفحه
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.UpdateDateTime))]

		public System.DateTime UpdateDateTime { get; set; }
		// **********

		// **********
		/// <summary>
		/// فعال بودن صفحه
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsActive))]

		public bool IsActive { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان حذف صفحه
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.DeleteDateTime))]

		public System.DateTime? DeleteDateTime { get; set; }
		// **********

		// **********
		/// <summary>
		/// آیا صفحه مورد نظر حذف شده است؟
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.IsDeleted))]

		public bool IsDeleted { get; set; }
		// **********

		// **********
		/// <summary>
		/// حذف کاربر با آیدی مورد نظر
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.RemoverUserId))]

		public System.Guid RemoverUserId { get; set; }
		// **********


	}
}
