using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ourU_NetStandard.Models
{
    public class Listing
    {
        [Newtonsoft.Json.JsonProperty("ListingPrice")]
        public double theListingPrice;

        [Newtonsoft.Json.JsonProperty("ListingStatus")]
        public string theListingStatus;

        [Newtonsoft.Json.JsonProperty("Department")]
        public string theDepartment;

        [Newtonsoft.Json.JsonProperty("Course")]
        public string theCourse;

        [Newtonsoft.Json.JsonProperty("Section")]
        public string theSection;

        [Newtonsoft.Json.JsonProperty("Comment")]
        public string theComment;

        [Newtonsoft.Json.JsonProperty("Photo")]
        public Image thePhoto;

        [Newtonsoft.Json.JsonProperty("User")]
        public string theUserName;

        [Newtonsoft.Json.JsonProperty("PhoneNum")]
        public string thePhoneNum;

        [Newtonsoft.Json.JsonProperty("Email")]
        public string theEmail;

        [Newtonsoft.Json.JsonProperty("PostDate")]
        public string thePostDate;
    }
}
