using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControl.Controls
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DemoSlider : ContentPage
	{
		public DemoSlider ()
		{
			InitializeComponent ();
		}
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            double value = args.NewValue;
            rotatingLabel.Rotation = value;
            displayLabel.Text = String.Format("The Slider value is {0}", value);
        }
    }
}