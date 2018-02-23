
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
            
            var etext = string.IsNullOrWhiteSpace(email.Text) ;
            var passtext = string.IsNullOrWhiteSpace(pass.Text);

         if( etext == true || passtext == true){
                return;
            }
         else
            {
                email.Text = string.Empty;
                pass.Text = string.Empty;
                await Navigation.PushAsync(new SchoolSelect());
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
