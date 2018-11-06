using System;

using Xamarin.Forms;

namespace ourU_NetStandard.Models
{
    public class Book : ContentPage
    {

        [Newtonsoft.Json.JsonProperty("Id")]
        public string theISBN;

        [Microsoft.WindowsAzure.MobileServices.Version]
        public string AzureVersion { get; set; }

        public string theAuthor;

        public string theTitle;

        public string thePrice;

        public string theStatus;

        public string theEdition;


    }
}

