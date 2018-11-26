using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ourU_NetStandard.Views
{
    public partial class ChangePasswordPage : ContentPage
    {
        public ChangePasswordPage()
        {
            InitializeComponent();
        }

        async void Cancle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PersonalInfoPage());
        }
    }
}
