using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;
using Xamarin.Forms;

namespace ourU_NetStandard.Services
{
    public class AzureMobileService
    {
        IMobileServiceClient client;
        IMobileServiceSyncTable <Models.Book> bookTable;

       
        public async Task Initialize()
        {
            client = new MobileServiceClient("https://ouru.azurewebsites.net");
            const string path = "Book.db";
            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable<Models.Book>();
            await client.SyncContext.InitializeAsync(store);
            bookTable = client.GetSyncTable<Models.Book>();
        }

        public async Task<bool> AddBook(Models.Book newBook)
        {
            try
            {

                await bookTable.InsertAsync(newBook); 
                await SyncAsync();
                return true;
            }

           
            catch (Exception e)
            {
                string result = e.Message.ToString();
                return false;
            }

        }

        public async Task SyncAsync()
        {
            ReadOnlyCollection<MobileServiceTableOperationError> syncErrors = null;

            try
            {
                await client.SyncContext.PushAsync();
                // The first parameter is a query name that is used internally by the client 
                // SDK to implement incremental sync.
                // Use a different query name for each unique query in your program.
                await bookTable.PullAsync("Books", bookTable.CreateQuery());
            }

            catch (MobileServicePushFailedException exc)
            {
                if (exc.PushResult != null)
                {
                    syncErrors = exc.PushResult.Errors;
                }
            }

            // Simple error/conflict handling.
            if (syncErrors != null)
            {
                foreach (var error in syncErrors)
                {
                    if (error.OperationKind == MobileServiceTableOperationKind.Update && error.Result != null)
                    {
                        // Update failed, revert to server's copy
                        await error.CancelAndUpdateItemAsync(error.Result);
                    }
                    else
                    {
                        // Discard local change
                        await error.CancelAndDiscardItemAsync();
                    }

                    Debug.WriteLine(@"Error executing sync operation. Item: {0} ({1}). Operation discarded.", 
                        error.TableName, error.Item["id"]);
                }
            }
        }

        public async Task clearDeleted()
        {
            await bookTable.PurgeAsync(bookTable.Where(book => book.isDeleted));
        }

        public async Task getBooksAsync(List<Models.Book> theList)
        {
            await SyncAsync();

            try
            {
                List<Models.Book> test = await bookTable.ToListAsync();
                foreach (var temp in test)
                    theList.Add(temp);
            }

            catch (Exception e)
            {
                string result = e.Message.ToString();
            }


        }

    }
}

