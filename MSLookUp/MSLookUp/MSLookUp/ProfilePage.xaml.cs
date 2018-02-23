using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSLookUp
{
    public partial class ProfilePage : TabbedPage
    {

        public ProfilePage() 
        {
            
            

              

            InitializeComponent();
        }

        async void Handle_Activated(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
