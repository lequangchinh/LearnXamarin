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
	public partial class DemoBindingContex : ContentPage
	{
        public DemoBindingContex()
        {
            InitializeComponent();
            lblSize.BindingContext = sldTextSize1;
            lblSize.Text = "Text Size";
            lblSize.SetBinding(Label.FontSizeProperty, "Value");
            sldTextSize1.ValueChanged += (sender, args) =>
            {
                lblSize.Text = String.Format("Text Size {0:F0}", args.NewValue);
            };
        }
	}
}