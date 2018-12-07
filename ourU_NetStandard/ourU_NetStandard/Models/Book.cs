using System;

using Xamarin.Forms;

namespace ourU_NetStandard.Models
{
    public class Book
    {

        [Newtonsoft.Json.JsonProperty("id")]
        public string theID;

        [Newtonsoft.Json.JsonProperty("ISBN")]
        public string theISBN;

        [Newtonsoft.Json.JsonProperty("Author")]
        public string theAuthor;

        [Newtonsoft.Json.JsonProperty("Title")]
        public string theTitle;

        [Newtonsoft.Json.JsonProperty("Price")]
        public string thePrice;

        [Newtonsoft.Json.JsonProperty("Status")]
        public string theStatus;

        [Newtonsoft.Json.JsonProperty("Edition")]
        public string theEdition;

        [Newtonsoft.Json.JsonProperty("Class")]
        public string theClass;

        [Newtonsoft.Json.JsonProperty("deleted")]
        public bool isDeleted;
        
        [Newtonsoft.Json.JsonProperty("isBook")]
        public bool isBook;
         [Newtonsoft.Json.JsonProperty("isListing")]
        public bool isListing;
         [Newtonsoft.Json.JsonProperty("Phone")]
        public string phoneNumber;
         [Newtonsoft.Json.JsonProperty("Email")]
        public string emailAddress;
         [Newtonsoft.Json.JsonProperty("Name")]
        public string userName;
         [Newtonsoft.Json.JsonProperty("Comment")]
        public string userComment;

    }
}

