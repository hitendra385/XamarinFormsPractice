using System;
using Xamarin.Forms;

namespace XamarinForms.Classes
{
    public static class Behaviour
    {
        public static readonly BindableProperty VerifyNumericValueProperty =
            BindableProperty.CreateAttached("VerifyNumericValue", typeof(bool), typeof(Behavior), false,BindingMode.TwoWay,null,HandleBindingPropertyChangedDelegate1);

        public static bool GetVerifyNumericValue(BindableObject view)
        {
            return (bool)view.GetValue(VerifyNumericValueProperty);
        }

        public static void SetVerifyNumericValue(BindableObject view,bool value)
        {
            view.SetValue(VerifyNumericValueProperty,value);
        }


        static void HandleBindingPropertyChangedDelegate1(BindableObject bindable, object oldValue, object newValue)
        {
            var entry = bindable as Entry;
            if (entry == null)
            {
                return;
            }

            bool attachBehavior = (bool)newValue;
            if (attachBehavior)
            {
                entry.TextChanged += OnEntryTextChanged;
            }
            else
            {
                entry.TextChanged -= OnEntryTextChanged;
            }
        }

        static void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            double result;
            bool isValid = double.TryParse(args.NewTextValue, out result);
            ((Entry)sender).TextColor = isValid ? Color.Default : Color.Red;
        }
    }
}
