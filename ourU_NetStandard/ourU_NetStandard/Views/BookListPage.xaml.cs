using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ourU_NetStandard.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BookListPage : ContentPage
	{
        public Services.AzureMobileService azServ = new Services.AzureMobileService();
        public ObservableCollection<Models.Book> bookList = new ObservableCollection<Models.Book>();
        public List<Models.Book> testList = new List<Models.Book>();

        public BookListPage()
        {
            //InitializeComponent();
            azServ = new Services.AzureMobileService();
            azServ.Initialize();
            azServ.getBooksAsync(bookList);


        }
	}
}