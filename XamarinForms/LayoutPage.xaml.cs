using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinForms
{
    public partial class LayoutPage : MasterDetailPage
    {
        public LayoutPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Page1());
            IsPresented = true;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Detail = new Page2();
        }
    }
}
