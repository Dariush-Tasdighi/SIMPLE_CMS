namespace Models
{
	public class PostCategory : Base.Entity
	{

		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PostCategory>
		{
			public Configuration() : base()
			{

			}
		}
		#endregion/Configuration

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
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.ParentId))]

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

		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.PostCategoryTitle))]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(name: "IX_ParentId_Title", 2, IsUnique = true)]
		public string Title { get; set; }
		// **********

		// **********
		/// <summary>
		/// توضیحاتی در مورد دسته بندی
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Description))]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 100)]
		public string Description { get; set; }
		// **********

		// **********
		/// <summary>
		/// اولویت بندی دسته بندی
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Ordering))]

		[System.ComponentModel.DataAnnotations.Schema.Index
			(IsUnique = false, IsClustered = false)]
		public int? Ordering { get; set; }
		// **********

		// **********
		/// <summary>
		/// Posts برای اعمال کلید خارجی در
		/// The posts related to a specific category.
		/// One to many relation between PostCategory and Post from Object-Oriented view.
		/// </summary>
		public virtual System.Collections.Generic.IList<Post> Posts{ get; set; }
	}
}
