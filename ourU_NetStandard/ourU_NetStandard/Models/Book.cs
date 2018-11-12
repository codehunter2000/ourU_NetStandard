using System;

using Xamarin.Forms;

namespace ourU_NetStandard.Models
{
    public class Book
    {

        [Newtonsoft.Json.JsonProperty("Id")]
        public string theISBN;

        public string theAuthor;

        public string theTitle;

        public string thePrice;

        public string theStatus;

        public string theEdition;

        public string theClass;

    }
}

