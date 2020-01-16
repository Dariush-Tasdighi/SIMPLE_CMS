namespace Models
{
	public class User : Base.Entity
	{


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
	}
}
