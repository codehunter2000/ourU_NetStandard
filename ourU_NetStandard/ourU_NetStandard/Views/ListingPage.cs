using System;

using Xamarin.Forms;

namespace ourU_NetStandard.Views
{
    public class ListingPage : ContentPage
    {
        public ListingPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

