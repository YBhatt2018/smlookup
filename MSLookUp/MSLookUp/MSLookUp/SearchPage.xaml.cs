using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSLookUp
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            }

       async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var studentNumber = string.IsNullOrWhiteSpace(snumber.Text) ;
            var firstName = string.IsNullOrWhiteSpace(fname.Text);
            var lastName =string.IsNullOrWhiteSpace(lname.Text);

            if (studentNumber != true && firstName != true && lastName != true)
                await Navigation.PushAsync(new ReasultPage());
            else
                return;
        }
    }
}
