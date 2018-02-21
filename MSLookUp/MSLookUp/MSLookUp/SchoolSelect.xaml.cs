using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSLookUp
{
    public partial class SchoolSelect : ContentPage
    {
        public SchoolSelect()
        {
            InitializeComponent();
        }




        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (pickera == null)
            {

                nextSc.IsVisible = false;
            }
            else
                nextSc.IsVisible = true;
        }




        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }
    }
}
