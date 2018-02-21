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
            var studentNumber = snumber.Text;
            var firstName = fname.Text;
            var lastName = lname.Text;

            if (studentNumber != null || firstName != null || lastName != null)
                await Navigation.PushAsync(new ReasultPage());
            else
                return;
        }
    }
}
