using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MSLookUp
{
    public partial class ProfilePage : TabbedPage
    {
        public String sn3;
        public ProfilePage(string sn2) 
        { 


            InitializeComponent();    
           sn3 = sn2;
            trs.Text = sn3;
            pic.Source = "//Users/yogin/Desktop/photo/12345.jpg";


            timelist.ItemsSource = new List<Contact> {
                new Contact{period = 23 , classcode = "eenfnf" , absent = 5 , late = 3, teacher = "Ron"},
                new Contact{period = 34 , classcode = "eetfnf" , absent = 6 , late = 3 , teacher = "Rachel"},
                 new Contact{period = 56 , classcode = "yo" , absent = 7 , late = 4 , teacher = "aditya"}
            };
        }
       
        async void Handle_Activated(object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

       
    }
}
