namespace Models.Base
{
	public abstract class Entity : object
	{
		public Entity() : base()
		{
			Id =
				System.Guid.NewGuid();

			InsertDateTime = Tools.Utility.Now;
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
		public System.Guid Id { get; set; }
		// **********

		// **********
		/// <summary>
		/// تاریخ و زمان درج اطلاعات
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
	}
}
