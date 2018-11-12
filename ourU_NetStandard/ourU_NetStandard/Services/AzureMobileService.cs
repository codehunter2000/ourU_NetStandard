using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Xamarin.Forms;

namespace ourU_NetStandard.Services
{
    public class AzureMobileService
    {
        public MobileServiceClient MobileService { get; set; }
        IMobileServiceSyncTable<Models.Book> bookTable;

        public async Task Initialize()
        {
            MobileService = new MobileServiceClient("https://ouru.azurewebsites.net");
            const string path = "Books.db";
            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable<Models.Book>();
            await MobileService.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());
        }

        public async Task<IEnumerable> GetBooks()
        {
            await SyncBook();
            return await bookTable.ToListAsync();
        }

        public async Task<bool> AddBook(string isbn, string author, string title,
                                 string price, string status, string edition, string theClass)
        {
            try
            {
                var toAdd = new Models.Book
                {
                    theISBN = isbn,
                    theAuthor = author,
                    theTitle = title,
                    thePrice = price,
                    theStatus = status,
                    theEdition = edition,
                    theClass = theClass
                };

                await bookTable.InsertAsync(toAdd);
                await SyncBook();
                return true;
            }

            catch
            {
                return false;
            }

        }

        public async Task SyncBook()
        {
            await bookTable.PullAsync("allBooks", bookTable.CreateQuery());
            await MobileService.SyncContext.PushAsync();
        }
    }
}

