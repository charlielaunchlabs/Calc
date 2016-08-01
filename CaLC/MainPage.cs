using System;

using Xamarin.Forms;

namespace CaLC
{
	public class MainPage : ContentPage
	{
		public static Label first = new Label() { TextColor = Color.White };
		public static Label second = new Label() { TextColor = Color.White ,HorizontalOptions=LayoutOptions.EndAndExpand,VerticalOptions=LayoutOptions.Fill,FontSize = Device.GetNamedSize(NamedSize.Large,typeof(Label))};
		public MainPage()
		{
			BlackScreen x = new BlackScreen();
			Numberz y = new Numberz();
			Content = new StackLayout
			{
				Padding = new Thickness(5, 20, 5, 5),
				Orientation = StackOrientation.Vertical,
				Children = {
					x,y
				}
			};
		}
	}
}


