using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DemoRadioButton 
{
    public class RadioButtonRenderer : ViewRenderer<CustomRadioButton, RadioButton>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomRadioButton> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {
                e.OldElement.PropertyChanged += ElementOnPropertyChanged;
            }
            if (this.Control == null)
            {
                var radButton = new RadioButton(this.Context);
                this.SetNativeControl(radButton);
            }
            Control.Text = e.NewElement.Text;
            Control.Checked = e.NewElement.Checked;
            Element.PropertyChanged += ElementOnPropertyChanged;
        }
        void ElementOnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Checked":
                    Control.Checked = Element.Checked;
                    break;
                case "Text":
                    Control.Text = Element.Text;
                    break;
            }
        }
    }
}
