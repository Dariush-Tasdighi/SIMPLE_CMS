using System.Linq;
using System.Web.Mvc.Html;
//using CaptchaMvc.HtmlHelpers;

namespace Infrastructure
{
	public static class CustomHtmlHelper
	{
		static CustomHtmlHelper()
		{
		}

		public static System.Web.IHtmlString DtxHorizontalLine(this System.Web.Mvc.HtmlHelper htmlHelper)
		{
			string result = "<hr />";

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxHeader
			(this System.Web.Mvc.HtmlHelper htmlHelper, string text)
		{
			text = Dtx.Text.Fix(text: text);

			if (text == string.Empty)
			{
				return null;
			}

			string result =
				$"<h2>{ text }</h2>";

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxSubHeader
			(this System.Web.Mvc.HtmlHelper htmlHelper, string text)
		{
			text = Dtx.Text.Fix(text: text);

			if (text == string.Empty)
			{
				return null;
			}

			string result =
				$"<h4>{ text }</h4>";

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxDisplayDateTime
			(this System.Web.Mvc.HtmlHelper htmlHelper, System.DateTime? value, bool displayTime = true)
		{
			string result =
				Convert.DateTime(value: value, displayTime: displayTime);

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxDisplay
			(this System.Web.Mvc.HtmlHelper htmlHelper, long? value)
		{
			string result =
				Convert.Number(value: value);

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxDisplayYear
			(this System.Web.Mvc.HtmlHelper htmlHelper, long? value)
		{
			if (value.HasValue == false)
			{
				return htmlHelper.Raw("----");
			}

			string result =
				value.Value.ToString();

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxDisplayMonth
			(this System.Web.Mvc.HtmlHelper htmlHelper, long? value)
		{
			if (value.HasValue == false)
			{
				return htmlHelper.Raw("--");
			}

			string result =
				value.Value.ToString().PadLeft(2, '0');

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxDisplayDay
			(this System.Web.Mvc.HtmlHelper htmlHelper, long? value)
		{
			if (value.HasValue == false)
			{
				return htmlHelper.Raw("--");
			}

			string result =
				value.Value.ToString().PadLeft(2, '0');

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxDisplayHour
			(this System.Web.Mvc.HtmlHelper htmlHelper, long? value)
		{
			if (value.HasValue == false)
			{
				return htmlHelper.Raw("--");
			}

			string result =
				value.Value.ToString().PadLeft(2, '0');

			return htmlHelper.Raw(result);
		}

		public static System.Web.IHtmlString DtxValidationSummary(
			this System.Web.Mvc.HtmlHelper html)
		{
			string message = string.Empty;

			object htmlAttributes =
				new { @class = "text-danger" };

			return html.ValidationSummary(excludePropertyErrors: true, message: message, htmlAttributes: htmlAttributes);

			// دقت کنید که دستورات ذیل خطا می‌دهد
			//string result =
			//	html.ValidationSummary(excludePropertyErrors: true, message: message, htmlAttributes: htmlAttributes)
			//	.ToHtmlString();

			//return html.Raw(result);
		}

		public static System.Web.IHtmlString DtxSimpleSubmitButton
			(this System.Web.Mvc.HtmlHelper html,
			string buttonCaption = null, string id = null, bool enabled = true, string cssClass = null)
		{
			string result = string.Empty;

			if (string.IsNullOrWhiteSpace(buttonCaption))
			{
				buttonCaption =
					Resources.Buttons.Submit;
			}

			if (string.IsNullOrWhiteSpace(cssClass))
			{
				cssClass = "btn btn-primary";
			}

			if (string.IsNullOrWhiteSpace(id))
			{
				if (enabled)
				{
					result =
						$"<button type=\"submit\" class=\"{ cssClass }\">{ buttonCaption }</button>";
				}
				else
				{
					result =
						$"<button type=\"submit\" class=\"{ cssClass }\" disabled=\"disabled\">{ buttonCaption }</button>";
				}
			}
			else
			{
				if (enabled)
				{
					result =
						$"<button type=\"submit\" class=\"{ cssClass }\" id=\"{ id }\">{ buttonCaption }</button>";
				}
				else
				{
					result =
						$"<button type=\"submit\" class=\"{ cssClass }\" id=\"{ id }\" disabled=\"disabled\">{ buttonCaption }</button>";
				}
			}

			return html.Raw(result);
		}

		public static System.Web.IHtmlString DtxSimpleResetButton
			(this System.Web.Mvc.HtmlHelper html, string buttonCaption = null, string cssClass = null)
		{
			string result = string.Empty;

			if (string.IsNullOrWhiteSpace(buttonCaption))
			{
				buttonCaption =
					Resources.Buttons.Reset;
			}

			if (string.IsNullOrWhiteSpace(cssClass))
			{
				cssClass = "btn btn-default";
			}

			result =
				$"<button type=\"reset\" class=\"{ cssClass }\">{ buttonCaption }</button>";

			return html.Raw(result);
		}

		public static System.Web.IHtmlString DtxSubmitButton
			(this System.Web.Mvc.HtmlHelper html,
			int columnOffset = 3, string submitButtonCaption = null,
			string submitButtonId = null, bool submitButtonEnabled = true,
			string submitButtonCssClass = null, bool displayResetButton = true,
			string resetButtonCaption = null, string resetButtonCssClass = null)
		{
			string result = "<div class=\"form-group\">";

			if (columnOffset < 0)
			{
				columnOffset = 0;
			}
			else
			{
				if (columnOffset > 11)
				{
					columnOffset = 11;
				}
			}

			if (columnOffset == 0)
			{
				result +=
					$"<div class=\"col-sm-12\">";
			}
			else
			{
				result +=
					$"<div class=\"col-sm-offset-{ columnOffset } col-sm-{ 12 - columnOffset }\">";
			}

			result +=
				DtxSimpleSubmitButton(html: html, buttonCaption: submitButtonCaption, id: submitButtonId,
				enabled: submitButtonEnabled, cssClass: submitButtonCssClass)
				.ToHtmlString();

			if (displayResetButton)
			{
				result +=
					" " +
					DtxSimpleResetButton(html: html, buttonCaption: resetButtonCaption, cssClass: resetButtonCssClass)
					.ToHtmlString();
			}

			result += "</div>";
			result += "</div>";

			return html.Raw(result);
		}

		public static System.Web.IHtmlString DtxSaveButton
			(this System.Web.Mvc.HtmlHelper html,
			int columnOffset = 3, string saveButtonCaption = null,
			string saveButtonId = null, bool saveButtonEnabled = true,
			string saveButtonCssClass = null, bool displayResetButton = true,
			string resetButtonCaption = null, string resetButtonCssClass = null)
		{
			if (string.IsNullOrWhiteSpace(saveButtonCaption))
			{
				saveButtonCaption =
					Resources.Buttons.Save;
			}

			string result =
				DtxSubmitButton
				(html: html,
				columnOffset: columnOffset, submitButtonCaption: saveButtonCaption,
				submitButtonId: saveButtonId, submitButtonEnabled: saveButtonEnabled,
				submitButtonCssClass: saveButtonCssClass, displayResetButton: displayResetButton,
				resetButtonCaption: resetButtonCaption, resetButtonCssClass: resetButtonCssClass)
				.ToHtmlString();

			return html.Raw(result);
		}

		public static System.Web.IHtmlString DtxCreateButton
			(this System.Web.Mvc.HtmlHelper html,
			int columnOffset = 3, string createButtonCaption = null,
			string createButtonId = null, bool createButtonEnabled = true,
			string createButtonCssClass = null, bool displayResetButton = true,
			string resetButtonCaption = null, string resetButtonCssClass = null)
		{
			if (string.IsNullOrWhiteSpace(createButtonCaption))
			{
				createButtonCaption =
					Resources.Buttons.Create;
			}

			string result =
				DtxSubmitButton
				(html: html,
				columnOffset: columnOffset, submitButtonCaption: createButtonCaption,
				submitButtonId: createButtonId, submitButtonEnabled: createButtonEnabled,
				submitButtonCssClass: createButtonCssClass, displayResetButton: displayResetButton,
				resetButtonCaption: resetButtonCaption, resetButtonCssClass: resetButtonCssClass)
				.ToHtmlString();

			return html.Raw(result);
		}

		public static System.Web.IHtmlString DtxDeleteButton
			(this System.Web.Mvc.HtmlHelper html,
			string deleteButtonCaption = null,
			string deleteButtonId = null, bool deleteButtonEnabled = true,
			string deleteButtonCssClass = null)
		{
			if (string.IsNullOrWhiteSpace(deleteButtonCaption))
			{
				deleteButtonCaption =
					Resources.Buttons.Delete;
			}

			if (string.IsNullOrWhiteSpace(deleteButtonCssClass))
			{
				deleteButtonCssClass = "btn btn-danger";
			}

			string result =
				"<div class=\"form-actions no-color\">";

			result +=
				DtxSimpleSubmitButton(
					html: html,
					id: deleteButtonId,
					enabled: deleteButtonEnabled,
					cssClass: deleteButtonCssClass,
					buttonCaption: deleteButtonCaption
					).ToHtmlString();

			result += "</div>";

			return html.Raw(result);
		}

		public static System.Web.Mvc.MvcHtmlString DtxLabelFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			int column = 0, bool ignoreFor = false,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null)
		{
			System.Web.Mvc.ModelMetadata modelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			string htmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			string labelText =
				modelMetadata.DisplayName ??
				modelMetadata.PropertyName ??
				htmlFieldName.Split('.').Last();

			if (string.IsNullOrEmpty(labelText))
			{
				return System.Web.Mvc.MvcHtmlString.Empty;
			}

			System.Web.Mvc.TagBuilder label =
				new System.Web.Mvc.TagBuilder("label");

			if (htmlAttributes != null)
			{
				label.MergeAttributes(htmlAttributes);
			}

			if (ignoreFor == false)
			{
				label.Attributes.Add("for",
					html.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldId(htmlFieldName));
			}

			label.SetInnerText(labelText);

			label.AddCssClass("control-label");

			if ((column >= 1) && (column <= 12))
			{
				label.AddCssClass("col-sm-" + column);
			}

			string labelString =
				label.ToString(System.Web.Mvc.TagRenderMode.Normal);

			var result =
				System.Web.Mvc.MvcHtmlString.Create(labelString);

			return result;
		}

		public static System.Web.Mvc.MvcHtmlString DtxLabel
			(this System.Web.Mvc.HtmlHelper html,
			string labelText,
			string expression = null,
			int column = 0,
			System.Collections.Generic.IDictionary<string, object> htmlAttributes = null)
		{
			System.Web.Mvc.TagBuilder label =
				new System.Web.Mvc.TagBuilder("label");

			if (htmlAttributes != null)
			{
				label.MergeAttributes(htmlAttributes);
			}

			label.SetInnerText(labelText);

			label.AddCssClass("control-label");

			if ((column >= 1) && (column <= 12))
			{
				label.AddCssClass("col-sm-" + column);
			}

			string labelString =
				label.ToString(System.Web.Mvc.TagRenderMode.Normal);

			var result =
				System.Web.Mvc.MvcHtmlString.Create(labelString);

			return result;
		}

		public static System.Web.IHtmlString DtxLabelAndEditorFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			int labelColumn = 3, bool readOnly = false,
			//object additionalViewData = null,
			int hintColumn = 0, string hint = null
			//bool leftToRight = false
			)
		{
			string result = string.Empty;

			System.Web.Mvc.ModelMetadata modelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			//string htmlFieldName =
			//	System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			bool isBoolean = false;

			if (modelMetadata.ModelType == typeof(bool))
			{
				isBoolean = true;
			}

			//if (leftToRight)
			//{
			//	editorAttributes.Add("class", "ltr");
			//}

			result +=
				"<div class=\"form-group\">";

			result +=
				DtxLabelFor(html, expression: expression, column: labelColumn);

			result +=
				$"<div class=\"col-sm-{ 12 - labelColumn - hintColumn }\">";

			object htmlAttributes = null;

			if (readOnly == false)
			{
				if (isBoolean == false)
				{
					htmlAttributes =
						new
						{
							@class = "form-control",
						};
				}
			}
			else
			{
				if (isBoolean == false)
				{
					htmlAttributes =
						new
						{
							@readonly = "readonly",
							@class = "form-control",
						};
				}
				else
				{
					htmlAttributes =
						new
						{
							@disabled = "disabled",
						};
				}
			}

			var viewData = new { htmlAttributes };

			// دستور ذیل در استانداردهای مایکروسافت وجود ندارد ولی در گوشی مبایل خیلی جذاب دیده نمی‌شود
			//if (isBoolean)
			//{
			//	result += "<div class=\"checkbox\">";
			//}

			string editorFor =
				html.EditorFor(expression: expression, additionalViewData: viewData)
				.ToHtmlString();

			result += editorFor;

			var validationHtmlAttributes =
				new { @class = "text-danger" };

			string validationMessageFor =
				html.ValidationMessageFor(expression: expression, validationMessage: string.Empty, htmlAttributes: validationHtmlAttributes)
				.ToHtmlString();

			result += validationMessageFor;

			// دستور ذیل در استانداردهای مایکروسافت وجود ندارد ولی در گوشی مبایل خیلی جذاب دیده نمی‌شود
			//if (isBoolean)
			//{
			//	result += "</div>";
			//}

			result += "</div>";

			if (hintColumn > 0)
			{
				result +=
					DtxLabel(html, labelText: hint, column: hintColumn);

				//result +=
				//	$"<div class=\"col-sm-{ hintColumn }\">";

				//if (string.IsNullOrWhiteSpace(hint) == false)
				//{
				//	result += hint.Trim();
				//}

				//result += "</div>";
			}

			result += "</div>";

			return html.Raw(result);
		}

		public static System.Web.IHtmlString DtxLabelAndEnumDropDownListFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			int labelColumn = 3, bool readOnly = false,
			//bool leftToRight = false,
			string optionLabel = null)
		{
			string result = string.Empty;

			// **************************************************
			string cssClass = "form-control";

			//if (leftToRight)
			//{
			//	cssClass =
			//		string.Format("{0} ltr", cssClass);
			//}
			// **************************************************

			result += "<div class=\"form-group\">";

			result +=
				DtxLabelFor(html: html, expression: expression, column: labelColumn);

			result +=
				$"<div class=\"col-sm-{ 12 - labelColumn }\">";

			// **************************************************
			System.Web.Mvc.ModelMetadata modelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			string htmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);
			// **************************************************

			// **************************************************
			object htmlAttributes = null;

			if (readOnly)
			{
				optionLabel = null;

				// TODO: تست شود که کدامیک از دو دستور مناسب است
				//htmlAttributes =
				//	new { @class = cssClass, disabled = "disabled" };

				// TODO: تست شود که کدامیک از دو دستور مناسب است
				htmlAttributes =
					new { @class = cssClass, @readonly = "readonly" };
			}
			else
			{
				if (modelMetadata.IsRequired == false)
				{
					if (optionLabel == null)
					{
						optionLabel =
							Resources.Messages.YouCanSelectAnItem;
					}

					htmlAttributes = new { @class = cssClass };
				}
				else
				{
					if (optionLabel == null)
					{
						optionLabel =
							Resources.Messages.YouShouldSelectAnItem;
					}

					// **************************************************
					string errorMessage =
						Resources.Messages.RequiredValidationErrorMessage;

					string displayName =
						modelMetadata.DisplayName ??
						modelMetadata.PropertyName ??
						htmlFieldName.Split('.').Last();

					if (string.IsNullOrWhiteSpace(displayName) == false)
					{
						errorMessage =
							string.Format(Resources.Messages.RequiredValidationErrorMessage, displayName);
					}
					// **************************************************

					htmlAttributes =
						new { @class = cssClass, data_val = "true", data_val_required = errorMessage };
				}
			}
			// **************************************************

			string dropDownList =
				html.EnumDropDownListFor
				(expression: expression, optionLabel: optionLabel, htmlAttributes: htmlAttributes)
				.ToHtmlString();

			result += dropDownList;

			var validationHtmlAttributes =
				new { @class = "text-danger" };

			string validationMessageFor =
				html.ValidationMessageFor(expression: expression, validationMessage: string.Empty, htmlAttributes: validationHtmlAttributes)
				.ToHtmlString();

			result += validationMessageFor;

			result += "</div>";
			result += "</div>";

			return html.Raw(result);
		}

		public static System.Web.IHtmlString DtxLabelAndDropDownListFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			int labelColumn = 3, bool readOnly = false,
			//bool leftToRight = false,
			string optionLabel = null)
		{
			string result = string.Empty;

			// **************************************************
			string cssClass = "form-control";

			//if (leftToRight)
			//{
			//	cssClass =
			//		string.Format("{0} ltr", cssClass);
			//}
			// **************************************************

			result += "<div class=\"form-group\">";

			result +=
				DtxLabelFor(html: html, expression: expression, column: labelColumn);

			result +=
				$"<div class=\"col-sm-{ 12 - labelColumn }\">";

			// **************************************************
			System.Web.Mvc.ModelMetadata modelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			string htmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);
			// **************************************************

			// **************************************************
			object htmlAttributes = null;

			if (readOnly)
			{
				optionLabel = null;

				// TODO: تست شود که کدامیک از دو دستور مناسب است
				//htmlAttributes =
				//	new { @class = cssClass, disabled = "disabled" };

				// TODO: تست شود که کدامیک از دو دستور مناسب است
				htmlAttributes =
					new { @class = cssClass, @readonly = "readonly" };
			}
			else
			{
				if (modelMetadata.IsRequired == false)
				{
					if (optionLabel == null)
					{
						optionLabel =
							Resources.Messages.YouCanSelectAnItem;
					}

					htmlAttributes = new { @class = cssClass };
				}
				else
				{
					if (optionLabel == null)
					{
						optionLabel =
							Resources.Messages.YouShouldSelectAnItem;
					}

					// **************************************************
					string errorMessage =
						Resources.Messages.RequiredValidationErrorMessage;

					string displayName =
						modelMetadata.DisplayName ??
						modelMetadata.PropertyName ??
						htmlFieldName.Split('.').Last();

					if (string.IsNullOrWhiteSpace(displayName) == false)
					{
						errorMessage =
							string.Format(Resources.Messages.RequiredValidationErrorMessage, displayName);
					}
					// **************************************************

					htmlAttributes =
						new { @class = cssClass, data_val = "true", data_val_required = errorMessage };
				}
			}
			// **************************************************

			string dropDownList =
				html.DropDownList
				(name: htmlFieldName, selectList: null, optionLabel: optionLabel, htmlAttributes: htmlAttributes)
				.ToHtmlString();

			result += dropDownList;

			var validationHtmlAttributes =
				new { @class = "text-danger" };

			string validationMessageFor =
				html.ValidationMessageFor(expression: expression, validationMessage: string.Empty, htmlAttributes: validationHtmlAttributes)
				.ToHtmlString();

			result += validationMessageFor;

			result += "</div>";
			result += "</div>";

			return html.Raw(result);
		}

		//public static System.Web.IHtmlString DtxCaptcha
		//	(this System.Web.Mvc.HtmlHelper html,
		//	int labelColumn = 3)
		//{
		//	string result = string.Empty;

		//	if (Settings.Instance.DisplayCaptchaImage)
		//	{
		//		result +=
		//			"<div class=\"form-group\">";

		//		string caption =
		//			Resources.DataDictionary.SecurityCode;

		//		if ((labelColumn >= 1) && (labelColumn <= 12))
		//		{
		//			result +=
		//				$"<label class=\"control-label col-sm-{ labelColumn }\">{ caption }</label>";
		//		}
		//		else
		//		{
		//			result +=
		//				$"<label class=\"control-label\">{ caption }</label>";
		//		}

		//		result +=
		//			$"<div class=\"col-sm-{ 12 - labelColumn }\">";

		//		result +=
		//			html.Captcha(6, MVC.Shared.Views.PartialViews._DisplayCaptchaImage)
		//			.ToHtmlString();

		//		result += "</div>";
		//		result += "</div>";
		//	}

		//	return html.Raw(result);
		//}

		public static System.Web.IHtmlString DtxDisplayNameAndValueFor<TModel, TValue>
			(this System.Web.Mvc.HtmlHelper<TModel> html,
			System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression,
			Enums.DisplayValueType displayValueType = Enums.DisplayValueType.Undefined,
			int labelColumn = 3,
			string caption = null
			//System.Web.Mvc.ActionResult actionResult = null
			)
		{
			//System.Web.Mvc.IT4MVCActionResult oT4MVCActionResult = null;

			//if (actionResult != null)
			//{
			//	oT4MVCActionResult =
			//		actionResult as System.Web.Mvc.IT4MVCActionResult;

			//	if (oT4MVCActionResult == null)
			//	{
			//		return null;
			//	}
			//}

			string result = "<div class='row'>";

			System.Web.Mvc.ModelMetadata modelMetadata =
				System.Web.Mvc.ModelMetadata.FromLambdaExpression(expression, html.ViewData);

			// **************************************************
			string labelStyle =
				"background-color: #f5f5f5; color: black; margin: 0px; padding: 4px; border: 1px solid darkgray";

			string htmlFieldName =
				System.Web.Mvc.ExpressionHelper.GetExpressionText(expression);

			if (string.IsNullOrWhiteSpace(caption))
			{
				caption =
					modelMetadata.DisplayName ??
					modelMetadata.PropertyName ??
					htmlFieldName.Split('.').Last();
			}

			result +=
				string.Format("<div class='col-sm-{0}' style='{1}'>",
				labelColumn, labelStyle);

			result += caption;

			result += "</div>";
			// **************************************************

			result +=
				string.Format("<div class='col-sm-{0}'>", 12 - labelColumn);

			object valueObject =
				modelMetadata.Model;

			string valueString;

			if (valueObject == null)
			{
				valueString =
					Dtx.Constant.DISPLAY_NULL_VALUE;
			}
			else
			{
				switch (displayValueType)
				{
					case Enums.DisplayValueType.Number:
					{
						valueString =
							Convert.Number(valueObject);

						break;
					}

					case Enums.DisplayValueType.Percent:
					{
						valueString =
							Convert.Number(valueObject);

						valueString +=
							" " + Resources.DataDictionary.Percent;

						break;
					}

					case Enums.DisplayValueType.Currency:
					{
						valueString =
							Convert.Number(valueObject);

						valueString +=
							" " + Resources.DataDictionary.Currency;

						break;
					}

					case Enums.DisplayValueType.Date:
					{
						try
						{
							System.DateTime dateTime =
								System.Convert.ToDateTime(valueObject);

							valueString =
								Convert.DateTime(dateTime, displayTime: false);
						}
						catch (System.Exception ex)
						{
							valueString =
								Dtx.Constant.DISPLAY_NULL_VALUE;

							//Dtx.Logger.LogError
							//	(type: typeof(CustomHtmlHelper), exception: ex);
						}

						break;
					}

					case Enums.DisplayValueType.DateTime:
					{
						try
						{
							System.DateTime dateTime =
								System.Convert.ToDateTime(valueObject);

							valueString =
								Convert.DateTime(dateTime, displayTime: true);
						}
						catch (System.Exception ex)
						{
							valueString =
								Dtx.Constant.DISPLAY_NULL_VALUE;

							//Dtx.Logger.LogError
							//	(type: typeof(CustomHtmlHelper), exception: ex);
						}

						break;
					}

					case Enums.DisplayValueType.Raw:
					{
						valueString =
							html.Raw(valueObject).ToHtmlString();

						break;
					}

					case Enums.DisplayValueType.Url:
					{
						valueString =
							string.Format("<a href='{0}'>{0}</a>", valueObject);

						break;
					}

					case Enums.DisplayValueType.EmailAddress:
					{
						valueString =
							string.Format("<a href='mailto:{0}'>{0}</a>", valueObject);

						break;
					}

					default:
					{
						valueString =
							html.DisplayFor(expression).ToHtmlString();

						break;
					}
				}
			}

			result += valueString;

			//if (actionResult == null)
			//{
			//	result += valueString;
			//}
			//else
			//{
			//	System.Web.Mvc.UrlHelper oUrlHelper =
			//		new System.Web.Mvc.UrlHelper(html.ViewContext.RequestContext);

			//	//strResult += oUrlHelper.Action
			//	//	(oT4MVCActionResult.Action,
			//	//	oT4MVCActionResult.Controller,
			//	//	oT4MVCActionResult.RouteValueDictionary);

			//	result +=
			//		html.ActionLink(linkText: valueString,
			//		actionName: oT4MVCActionResult.Action,
			//		controllerName: oT4MVCActionResult.Controller,
			//		routeValues: oT4MVCActionResult.RouteValueDictionary,
			//		htmlAttributes: null);
			//}

			result += "	</div>";
			result += "</div>";

			return html.Raw(result);
		}
	}
}
