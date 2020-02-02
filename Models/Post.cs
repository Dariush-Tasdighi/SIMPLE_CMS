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
		internal class Configuration:
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Post>
		{
			public Configuration():base()
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

		public string Description { get; set; }
		// **********


		// **********
		/// <summary>
		/// رمز عبور
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Password))]

		public string Password { get; set; }
		// **********


		// **********
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
		// **********
	}
}
