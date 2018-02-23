using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSLookUp
{
    public partial class ReasultPage : ContentPage
    {
        
        public ReasultPage()
        {
            InitializeComponent();

            ListView.ItemsSource = new List<Contact> {
                new Contact{lastName = "Bhatt" , firstName = "Yogin" , studentNumber = 434},       
                new Contact{lastName = "Patel" , firstName = "Tirth" , studentNumber = 453}       
            };

   
        }


        async  void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
            }
            else
                 await DisplayAlert("Item Selected", e.SelectedItem.ToString(), "Ok");

            var contact = e.SelectedItem as Contact;
            //var profilepage = new ProfilePage(contact);
            await Navigation.PushAsync(new ProfilePage() { BindingContext = contact });
            ListView.SelectedItem = null;
        }
    }
}
