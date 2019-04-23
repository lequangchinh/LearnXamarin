using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoGetsture
{
    public partial class MainPage : ContentPage
    {
        public int tapCount = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            tapCount++;
            var imageSender = (Image)sender;
            if (tapCount % 2 == 0)
            {
                imageSender.Source = "tapped.jpg";
            }
            else
            {
                imageSender.Source = "tapped_bw.jpg";
            }
        }
    }
}
