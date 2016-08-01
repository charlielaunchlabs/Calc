using System;
using Xamarin.Forms;


namespace CaLC
{
	public class BlackScreen : StackLayout
	{
		
		public BlackScreen()
		{
			
			this.Orientation = StackOrientation.Vertical;
			this.Spacing = 0;
			StackLayout top = new StackLayout();
			top.Orientation = StackOrientation.Horizontal;
			top.BackgroundColor = Color.Black;
			top.HeightRequest = 50;
			top.Children.Add(MainPage.first);
			top.HorizontalOptions = LayoutOptions.FillAndExpand;
			StackLayout result = new StackLayout();
			result.Orientation = StackOrientation.Horizontal;
			result.BackgroundColor = Color.Black;
			result.HeightRequest = 70;
			result.Children.Add(MainPage.second);
			this.Children.Add(top);
			this.Children.Add(result);

		}
	}
}


