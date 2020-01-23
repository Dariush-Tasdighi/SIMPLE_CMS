namespace ViewModels.Account
{
	public class LoginViewModel : object
	{
		public LoginViewModel() : base()
		{
		}

		// **********
		public string ReturnUrl { get; set; }
		// **********

		// **********
		public string Username { get; set; }
		// **********

		// **********
		public string Password { get; set; }
		// **********
	}
}
