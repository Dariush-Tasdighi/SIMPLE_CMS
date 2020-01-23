namespace Infrastructure
{
	public static class Convert
	{
		static Convert()
		{
		}

		public static string Number(object value, string displayNullValue = Dtx.Constant.DISPLAY_NULL_VALUE)
		{
			if (value == null)
			{
				return displayNullValue;
			}

			try
			{
				long valueLong =
					System.Convert.ToInt64(value);

				return Number(valueLong, displayNullValue);
			}
			catch (System.Exception)
			{
				return displayNullValue;
			}
		}

		public static string Number(long? value, string displayNullValue = Dtx.Constant.DISPLAY_NULL_VALUE)
		{
			if (value.HasValue == false)
			{
				return displayNullValue;
			}

			string result =
				value.Value.ToString("#,##0");

			return result;
		}

		public static string
			DateTime(System.DateTime? value, bool displayTime = true, string displayNullValue = Dtx.Constant.DISPLAY_NULL_VALUE)
		{
			if (value.HasValue == false)
			{
				return displayNullValue;
			}

			System.Globalization.PersianCalendar
				persianCalendar = new System.Globalization.PersianCalendar();

			int year =
				persianCalendar.GetYear(value.Value);

			int month =
				persianCalendar.GetMonth(value.Value);

			int day =
				persianCalendar.GetDayOfMonth(value.Value);

			string dayString =
				day.ToString().PadLeft(2, '0');

			string monthString =
				month.ToString().PadLeft(2, '0');

			string result;

			if (displayTime == false)
			{
				result =
					$"{ year }/{ monthString }/{ dayString }";
			}
			else
			{
				result =
					$"{ year }/{ monthString }/{ dayString } - [{ value.Value.ToString("HH:mm:ss") }]";
			}

			return result;
		}
	}
}
