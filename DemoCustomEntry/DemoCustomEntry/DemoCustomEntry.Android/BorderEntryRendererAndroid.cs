using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using DemoCustomEntry;
using DemoCustomEntry.Droid;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Views;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(BorderEntryRendererAndroid))]
namespace DemoCustomEntry.Droid
{
    class BorderEntryRendererAndroid : EntryRenderer
    {
        public BorderEntryRendererAndroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var gradientDrawable = new GradientDrawable();
                gradientDrawable.SetCornerRadius(3f);
                gradientDrawable.SetColor(Android.Graphics.Color.Gray);
                gradientDrawable.SetStroke(3, Android.Graphics.Color.Green);
                Control.SetBackground(gradientDrawable);
                Control.Gravity = GravityFlags.CenterVertical | GravityFlags.Left;
            }
        }
    }
}

