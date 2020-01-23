namespace Dtx
{
	public static class Text
	{
		static Text()
		{
		}

		public static string Fix(string text)
		{
			if (text == null)
			{
				return string.Empty;
			}

			text = text.Trim();

			if (text == string.Empty)
			{
				return string.Empty;
			}

			while (text.Contains("  "))
			{
				text =
					text.Replace("  ", " ");
			}

			return text;
		}
	}
}
