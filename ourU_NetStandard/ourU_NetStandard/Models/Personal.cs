using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ourU_NetStandard.Models
{
    public class Personal
    {
        [Newtonsoft.Json.JsonProperty("UserPhoto")]
        public Image theUserPhoto;

        [Newtonsoft.Json.JsonProperty("FirstName")]
        public string theFirstName;

        [Newtonsoft.Json.JsonProperty("LastName")]
        public string theLastName;

        [Newtonsoft.Json.JsonProperty("EmailAddress")]
        public string theEmailAddress;

        [Newtonsoft.Json.JsonProperty("PhoneNumb")]
        public string thePhoneNumb;
    }
}