using System;
using Xamarin.Forms;

namespace Actividad3
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage { 
				Content = new Label {
					Text = "Miguel Angel Santamaria Rosas 088327817",
					VerticalOptions = LayoutOptions.Fill,
					HorizontalOptions = LayoutOptions.End,
					BackgroundColor = Color.Blue,
					TextColor = Color.Green
				},
			};
		}
	}
}

