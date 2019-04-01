using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoControl.Controls.Text
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextEditorDemo : ContentPage
	{
		public TextEditorDemo ()
		{
			InitializeComponent ();
		}

        void EditorCompleted(object sender, EventArgs e)
        {
            var text = ((Editor)sender).Text;
            textEditor.Text = text;
        }
    }
}