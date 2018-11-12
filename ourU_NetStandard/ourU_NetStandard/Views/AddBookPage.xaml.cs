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
        Services.AzureMobileService azserv = new Services.AzureMobileService();
        public AddBookPage ()
		{
			InitializeComponent ();
            azserv.Initialize();
		}
        
        public async void ListBook_Clicked(object sender, System.EventArgs e)
        {

            var isbn = bookISBNEntry.Text;
            var title = bookTitleEntry.Text;
            var author = bookAuthorEntry.Text;
            var status = bookStatusEntry.Text;
            var theClass = bookClassEntry.Text;
            var edition = bookEditionEntry.Text;
            var price = bookPriceEntry.Text;

            Models.Book toAdd = new Models.Book();
            toAdd.theISBN = isbn;
            toAdd.theTitle = title;
            toAdd.theAuthor = author;
            toAdd.theStatus = status;
            toAdd.theClass = theClass;
            toAdd.theEdition = edition;
            toAdd.thePrice = price;

            bool success = await azserv.AddBook(toAdd);

            if (success)
                await DisplayAlert("Success", "Your book has been posted successfully!", "OK");
            else
                await DisplayAlert("Error", "There was a problem listing your book!", "OK");
                
        }
        
    }
}