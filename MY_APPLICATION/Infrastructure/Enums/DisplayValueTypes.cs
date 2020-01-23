namespace Infrastructure.Enums
{
	public enum DisplayValueType : int
	{
		Undefined = 0,

		Number,
		Percent,
		Currency,

		Date,
		DateTime,

		Raw,
		Url,
		EmailAddress,
	}
}
