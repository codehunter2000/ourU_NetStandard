using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ourU_NetStandard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalInfoPage : ContentPage
    {
        public PersonalInfoPage()
        {
            InitializeComponent();
        }

        async void LogOut_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LogInPage());
        }

        async void Edit_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EditPage());
        }

        async void ChangePass_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ChangePasswordPage());
        }
    }
}
