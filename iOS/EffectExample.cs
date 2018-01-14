using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinForms.iOS;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(EffectExample), "EffectExample")]
namespace XamarinForms.iOS
{
    public class EffectExample : PlatformEffect
    {
        public EffectExample()
        {
            
        }

        protected override void OnAttached()
        {
            var entry = Control as UITextField;
            if(String.IsNullOrWhiteSpace(entry.Text))
            entry.Layer.BorderColor = Color.Red.ToCGColor();
            entry.Layer.BorderWidth = 2;
        }

        protected override void OnDetached()
        {
            
        }

        protected override void OnElementPropertyChanged(System.ComponentModel.PropertyChangedEventArgs args)
        {

            var entry = Control as UITextField;
            if (!String.IsNullOrWhiteSpace(entry.Text))
            {
                entry.Layer.BorderColor = Color.Accent.ToCGColor();
                entry.Layer.BorderWidth = 2;
            }
            else
            {
                entry.Layer.BorderColor = Color.Red.ToCGColor();
                entry.Layer.BorderWidth = 2;
            }
        }
    }
}
