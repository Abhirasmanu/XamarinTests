using System;
using Xamarin.Forms;

namespace ScrollViewTest
{
	public class App
	{
	   
		public static Page GetMainPage ()
		{

            return new NavigationPage(new SampleScrollView());
		}
	}
}

