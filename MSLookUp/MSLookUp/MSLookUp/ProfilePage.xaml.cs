using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSLookUp
{
    public partial class ProfilePage : TabbedPage
    {
      
        public ProfilePage(Contact contact )
        {

            if (contact == null)
                throw new ArgumentNullException ();

            BindingContext = contact;  

            InitializeComponent();
        }

        async void Handle_Activated(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
