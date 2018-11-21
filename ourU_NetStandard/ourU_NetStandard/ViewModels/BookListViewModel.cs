using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace ourU_NetStandard.ViewModels
{
    class BookListViewModel : ContentPage
    {
       private Services.AzureMobileService azServ;
        private List<Models.Book> bookList;

        public BookListViewModel()
        {
            Label header = new Label
            {
                Text = "ListView",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

           bookList = new List<Models.Book>();
            azServ = new Services.AzureMobileService();
            azServ.Initialize();

            int size = bookList.Count();

            ListView listView = new ListView
            {

                ItemsSource = bookList,

                ItemTemplate = new DataTemplate(() =>
                {
                    // Create views with bindings for displaying each property.
                    Label nameLabel = new Label();
                    nameLabel.SetBinding(Label.TextProperty, "Name");

                    Label isbnLabel = new Label();
                    isbnLabel.SetBinding(Label.TextProperty, "ISBN");

                    BoxView boxView = new BoxView();
                    boxView.SetBinding(BoxView.ColorProperty, "FavoriteColor");

                    // Return an assembled ViewCell.
                    return new ViewCell
                    {
                        View = new StackLayout
                        {
                            Padding = new Thickness(0, 5),
                            Orientation = StackOrientation.Horizontal,
                            Children =
                                {
                                    boxView,
                                    new StackLayout
                                    {
                                        VerticalOptions = LayoutOptions.Center,
                                        Spacing = 0,
                                        Children =
                                        {
                                            nameLabel,
                                            isbnLabel
                                        }
                                    }
                            }
                        }
                    };
                })
            };
        }
    }
}
