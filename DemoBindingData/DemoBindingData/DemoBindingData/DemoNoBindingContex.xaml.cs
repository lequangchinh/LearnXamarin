using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoBindingData
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoNoBindingContex : ContentPage
	{
		public DemoNoBindingContex ()
		{
			InitializeComponent ();
            //lblText.SetBinding(Label.FontSizeProperty, new Binding("Value", source:sldFontSize));
            lblText.SetBinding(Label.RotationProperty, new Binding("Value", source:sldRotation));
		}
	}
}