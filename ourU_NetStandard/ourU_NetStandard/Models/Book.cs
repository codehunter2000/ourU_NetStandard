using System;

using Xamarin.Forms;

namespace ourU_NetStandard.Models
{
    public class Book
    {

        [Newtonsoft.Json.JsonProperty("id")]
        public string TheID { get; set; }

        [Newtonsoft.Json.JsonProperty("ISBN")]
        public string TheISBN { get; set; }

        [Newtonsoft.Json.JsonProperty("Author")]
        public string TheAuthor { get; set; }

        [Newtonsoft.Json.JsonProperty("Title")]
        public string TheTitle { get; set; }

        [Newtonsoft.Json.JsonProperty("Price")]
        public string ThePrice { get; set; }

        [Newtonsoft.Json.JsonProperty("Status")]
        public string TheStatus { get; set; }

        [Newtonsoft.Json.JsonProperty("Edition")]
        public string TheEdition { get; set; }

        [Newtonsoft.Json.JsonProperty("Class")]
        public string TheClass { get; set; }

        [Newtonsoft.Json.JsonProperty("deleted")]
        public bool IsDeleted { get; set; }
        
        [Newtonsoft.Json.JsonProperty("isBook")]
        public bool IsBook { get; set; }
         [Newtonsoft.Json.JsonProperty("isListing")]
        public bool IsListing { get; set; }
         [Newtonsoft.Json.JsonProperty("Phone")]
        public string PhoneNumber { get; set; }
         [Newtonsoft.Json.JsonProperty("Email")]
        public string EmailAddress { get; set; }
         [Newtonsoft.Json.JsonProperty("Name")]
        public string UserName { get; set; }
         [Newtonsoft.Json.JsonProperty("Comment")]
        public string UserComment { get; set; }
        
    }
}

