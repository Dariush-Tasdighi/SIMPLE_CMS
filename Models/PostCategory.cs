namespace Models
{
	public class PostCategory : Base.Entity
	{


		public PostCategory() : base()
		{
		}

		// **********
		// **********
		// **********
		/// <summary>
		/// ParentId روی ForeignKey ایجاد
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.ForeignKey(nameof(ParentId))]
		public PostCategory Parent { get; set; }
		// **********

		// **********
		/// <summary>
		/// برای اعمال درختواره بودن دسته بندی
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.Index
			(name: "IX_ParentId_Title", 1, IsUnique = true)]
		public System.Guid? ParentId { get; set; }
		// **********
		// **********
		// **********

		// **********
		/// <summary>
		/// عنوان دسته بندی
		/// </summary>
		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredValidationErrorMessage))]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 15)]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(name: "IX_ParentId_Title", 2, IsUnique = true)]
		public string Title { get; set; }
		// **********

		// **********
		/// <summary>
		/// توضیحاتی در مورد دسته بندی
		/// </summary>
		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Description { get; set; }
		// **********

		// **********
		/// <summary>
		/// اولویت بندی دسته بندی
		/// </summary>
		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false, IsClustered = false)]
		public int? Ordering { get; set; }
		// **********

		// **********
		/// <summary>
		/// Posts برای اعمال کلید خارجی در
		/// </summary>
		//public virtual System.Collections.Generic.IList<Post> Posts{ get; set; }
	}
}
