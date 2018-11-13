﻿using System;
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

            string isbn = bookISBNEntry.Text;
            string title = bookTitleEntry.Text;
            string author = bookAuthorEntry.Text;
            string status = bookStatusEntry.Text;
            string theClass = bookClassEntry.Text;
            string edition = bookEditionEntry.Text;
            string price = bookPriceEntry.Text;

            Models.Book toAdd = new Models.Book
            {
                theISBN = isbn,
                theTitle = title,
                theAuthor = author,
                theStatus = status,
                theClass = theClass,
                theEdition = edition,
                thePrice = price
            };

            bool success = await azserv.AddBook(toAdd);

            if (success)
                await DisplayAlert("Success", "Your book has been posted successfully!", "OK");
            else
                await DisplayAlert("Error", "There was a problem listing your book!", "OK");
                
        }
        
    }
}