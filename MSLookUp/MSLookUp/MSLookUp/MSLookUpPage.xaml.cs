
using Xamarin.Forms;

using Plugin.Fingerprint;
namespace MSLookUp
{
    public partial class MSLookUpPage : ContentPage
    {
        
        public MSLookUpPage()
        {
            InitializeComponent();
            //email.SetValue(AutomationProperties.IsInAccessibleTreeProperty, true);
            //AutomationProperties.SetHelpText(email, "Tap to toggle the activity indicator");

            //var userID = new Label { Text = "UserID" };
            //AutomationProperties.SetIsInAccessibleTree(userID, true);
            //AutomationProperties.SetHelpText(userID, "EMAIL LABEL");
         
        }


        async void Handle_Clicked_Login(object sender, System.EventArgs e)
        {

            var etext = email.Text;
            var passtext = pass.Text;

            if( etext != null || passtext != null){
                await Navigation.PushAsync(new SchoolSelect());
            }
                
         else
            {
                return;
            }
           
        }
      

        async void Handle_Clicked_FP(object sender, System.EventArgs e)
        {

            var result = await CrossFingerprint.Current.IsAvailableAsync(true); 
            if(result)
            {
                var auth = await CrossFingerprint.Current.AuthenticateAsync("Access to app");
                if (auth.Authenticated)
                {
                    await Navigation.PushAsync(new SchoolSelect());
                }
                else {

                    await DisplayAlert("Error","NotCorrect","ok" );
                }
            }
        }


        async  void Handle_Clicked_Password(object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new ResetPassPage());
        }

      
    }
}
