using System;
using Xamarin.Forms;

namespace Actividad4
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new ContentPage {
				Content = new Label {
					Text = "Miguel Angel Santamaría Rosas - 088327817",
					HorizontalOptions = LayoutOptions.Center,
					TextColor = Color.Blue
				},
			};
		}
	}
}

