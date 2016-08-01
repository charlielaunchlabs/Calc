using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using NCalc;
using Xamarin.Forms;
namespace CaLC
{
	public class Numberz : StackLayout
	{
		CCbutton a1, a2, a3, a4, a5, a6, a7, a8, a9, a0, plus, minus, multiply, divide, point, equal,clear,clr;
		string holder;
		public Numberz()
		{
			this.Orientation = StackOrientation.Vertical;
			this.HorizontalOptions = LayoutOptions.FillAndExpand;
			this.VerticalOptions = LayoutOptions.FillAndExpand;
	
			StackLayout a = new StackLayout();
			a.Orientation = StackOrientation.Horizontal;
			a.HorizontalOptions = LayoutOptions.FillAndExpand;
			a.VerticalOptions = LayoutOptions.FillAndExpand;
			a.Children.Add(a7 = new CCbutton {HorizontalOptions=LayoutOptions.FillAndExpand,VerticalOptions=LayoutOptions.FillAndExpand, Text = "7" });
			a.Children.Add(a8 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "8" });
			a.Children.Add(a9 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "9" });
			a.Children.Add(divide = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "÷" });
			StackLayout b = new StackLayout();
			b.Orientation = StackOrientation.Horizontal;
			b.HorizontalOptions = LayoutOptions.FillAndExpand;
			b.VerticalOptions = LayoutOptions.FillAndExpand;
			b.Children.Add(a4 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "4" });
			b.Children.Add(a5 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "5" });
			b.Children.Add(a6 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "6" });
			b.Children.Add(multiply = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "x" });
			StackLayout c = new StackLayout();
			c.Orientation = StackOrientation.Horizontal;
			c.HorizontalOptions = LayoutOptions.FillAndExpand;
			c.VerticalOptions = LayoutOptions.FillAndExpand;
			c.Children.Add(a1 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "1" });
			c.Children.Add(a2 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "2" });
			c.Children.Add(a3 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "3" });
			c.Children.Add(minus = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "-" });
			StackLayout d = new StackLayout();
			d.Children.Add(point = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "." });
			d.Children.Add(a0 = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "0" });
			d.Children.Add(equal = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "=" });
			d.Children.Add(plus = new CCbutton {HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "+" });
			d.Orientation = StackOrientation.Horizontal;
			d.VerticalOptions = LayoutOptions.FillAndExpand;
			d.HorizontalOptions = LayoutOptions.FillAndExpand;
			clear = new CCbutton { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "Clear All" };
			clr = new CCbutton { HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Text = "Clear" };
			this.Children.Add(new StackLayout { Orientation=StackOrientation.Horizontal,HorizontalOptions = LayoutOptions.FillAndExpand, VerticalOptions = LayoutOptions.FillAndExpand, Children = { clear,clr} });
			this.Children.Add(a);
			this.Children.Add(b);
			this.Children.Add(c);
			this.Children.Add(d);

			clr.Clicked += (sender, e) =>
			{
				if (MainPage.first.Text == "")
				{

					// -----
				}
				else 
				{
					MainPage.first.Text = MainPage.first.Text.Remove(MainPage.first.Text.Length - 1);
				}
			};
			clear.Clicked += (sender, e) =>
			{

				if (MainPage.first.Text == "")
				{

					// -----
				}
				else 
				{
					MainPage.first.Text = "";
					MainPage.second.Text = "";
					holder = "";
				}

			};
			a0.Clicked += (sender, e) =>
			{
				
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;

			};
			a1.Clicked += (sender, e) => 
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;

			};
			a2.Clicked += (sender, e) =>
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;
			};
			a3.Clicked += (sender, e) =>
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;
			};
			a4.Clicked += (sender, e) =>
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;
			};
			a5.Clicked += (sender, e) =>
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;
			};
			a6.Clicked += (sender, e) =>
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;
			};
			a7.Clicked += (sender, e) =>
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;
			};
			a8.Clicked += (sender, e) =>
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;
			};
			a9.Clicked += (sender, e) =>
			{
				MainPage.first.Text += ((CCbutton)sender).Text;
				holder = MainPage.first.Text;
			};
			plus.Clicked += (sender, e) =>
			{
				if (MainPage.second.Text == "")
				{
					MainPage.first.Text += "+";
				}
				else 
				{
					MainPage.first.Text = "";
					MainPage.first.Text += holder + "+";

				}
			
			};
			minus.Clicked += (sender, e) =>
			{
				if (MainPage.second.Text == "")
				{
					MainPage.first.Text += "-";
				}
				else
				{
					MainPage.first.Text = "";
					MainPage.first.Text += holder + "-";
				}

			};
			divide.Clicked += (sender, e) =>
			{
				if (MainPage.second.Text == "")
				{
					MainPage.first.Text += "/";
				}
				else
				{
					MainPage.first.Text = "";
					MainPage.first.Text += holder + "/";

				}

			};
			multiply.Clicked += (sender, e) =>
			{
				if (MainPage.second.Text == "")
				{
					MainPage.first.Text += "*";
				}
				else
				{
					MainPage.first.Text = "";
					MainPage.first.Text += holder + "*";

				}

			};


			point.Clicked += (sender, e) =>
			{


				if (MainPage.first.Text == "")
				{
					//MainPage.first.Text += ".";
				}
				else
				{
					string whole = MainPage.first.Text;
					int last = MainPage.first.Text.Length;
					string laststrand = whole.Substring(last-1);
					int n;
					if (int.TryParse(laststrand, out n))
					{
						MainPage.first.Text += ".";
					}
					else 
					{
					}

				}
			};


			equal.Clicked += (sender, e) =>		
			{
				
				Expression es = new Expression(MainPage.first.Text);


				try
				{
					MainPage.second.Text = es.Evaluate().ToString(); 
				}
				catch
				{
					MainPage.second.Text = "Math Error";
				}

				holder = MainPage.second.Text;
			};

		}

		//public string Answer()
		//{
		//	//Expression e = new Expression(MainPage.first.Text);
		//	//return e.Evaluate(.ToString();
		//}



	}
}


