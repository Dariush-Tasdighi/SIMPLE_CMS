namespace Models
{
	public class User : Base.Entity
	{

		#region Configuration
		internal class Configuration :
			System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
		{
			public Configuration() : base()
			{

			}
		}
		#endregion/Configuration


		public User() : base()
		{
		}

		// **********
		/// <summary>
		/// شماره منحصر به فرد
		/// </summary>
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.DataDictionary),
			Name = nameof(Resources.DataDictionary.Id))]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = nameof(Resources.Messages.RequiredValidationErrorMessage))]
		public string Username { get; set; }
		// **********

		public string Password { get; set; }


		// **********
		// **********
		// **********
		/// <summary>
		/// The posts created by users.
		/// One to many relation between Users and Posts from Object-Oriented view.
		/// </summary>
		public virtual System.Collections.Generic.IList<Post> WrittenPosts { get; set; }
		// **********

		// **********
		/// <summary>
		/// The posts verified by some special users.
		/// One to many relation between Users and Posts from Object-Oriented view.
		/// </summary>
		public virtual System.Collections.Generic.IList<Post> VerifiedPosts { get; set; }
		// **********
		// **********
		// **********
	}
}
