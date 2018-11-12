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
	public partial class AddBookPage : ContentPage
	{
        Services.AzureMobileService azserv;
        public AddBookPage ()
		{
			InitializeComponent ();
           
		}
        
        public async void ListBook_Clicked(object sender, System.EventArgs e)
        {
            
            await azserv.Initialize();

            var isbn = bookISBNEntry.Text;
            var title = bookTitleEntry.Text;
            var author = bookAuthorEntry.Text;
            var status = bookStatusEntry.Text;
            var theClass = bookClassEntry.Text;
            var edition = bookEditionEntry.Text;
            var price = bookPriceEntry.Text;

            bool success = await azserv.AddBook(isbn, author, title, price, status, edition);

            if (success)
                await DisplayAlert("Success", "Your book has been posted successfully!", "OK");
            else
                await DisplayAlert("Error", "There was a problem listing your book!", "OK");
                
        }
        
    }
}