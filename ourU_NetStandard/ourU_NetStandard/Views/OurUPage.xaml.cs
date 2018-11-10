using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ourU_NetStandard.Views
{

    public partial class OurUPage : ContentPage
    {
        public OurUPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        async void Login_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LogInPage());
        }

        async void About_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        async void Search_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SearchPage());
        }

        async void Personal_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PersonalInfoPage());
        }

        async void AddNewBook_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddBookPage());
        }
    }
}
