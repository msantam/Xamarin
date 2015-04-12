using System;

namespace Actividad7
{
	public class Pagina3
	{
		public Pagina3 ()
		{
			return new ContentPage {
				Content = new Label {
					Text = "Página 3",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};
		}
	}
}

