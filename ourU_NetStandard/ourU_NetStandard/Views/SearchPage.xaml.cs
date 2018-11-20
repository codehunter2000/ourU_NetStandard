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
	public partial class SearchPage : ContentPage
	{
       
        public SearchPage ()
		{
			InitializeComponent ();
		}
        async void BookItem_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new BookItemPage());
        }

        async void AddBook_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new AddBookPage());
        }

	}
}