using System.Linq;

namespace Models
{
	public class Post: Base.Entity
	{

		public Post():base()
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

	}
}
