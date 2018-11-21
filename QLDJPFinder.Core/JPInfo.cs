using System;
using Newtonsoft.Json;

namespace QLDJPFinder.Core
{
    public class JPInfo
    {
        [JsonProperty("_id")]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public string Services { get; set; }

        [JsonProperty("Office type")]
        public string OfficeType { get; set; }

        [JsonProperty("Counter type")]
        public string CounterType { get; set; }

        [JsonProperty("Address 1")]
        public string Address1 { get; set; }

        [JsonProperty("Address 2")]
        public string Address2 { get; set; }

        public string Suburb { get; set; }

        [JsonProperty("Postcode")]
        public int PostCode { get; set; }

        [JsonProperty("Postal address 1")]
        public string PostalAddress1 { get; set; } //"Postal address 1": "",

        [JsonProperty("Postal address 2")]
        public string PostalAddress2 { get; set; } // "Postal address 2": "",
        //"Postal suburb": "",
        //"Postal postcode": "",

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Phone { get; set; }

        //"Fax": "",

        public string Email { get; set; }

        //"Mon am": "10:00-12:00",
        //"Mon pm": "",
        //"Tues am": "",
        //"Tues pm": "",
        //"Wed am": "",
        //"Wed pm": "",
        //"Thurs am": "",
        //"Thurs pm": "17:30-19:30",
        //"Fri am": "",
        //"Fri pm": "",
        //"Sat am": "",
        //"Sat pm": "",
        //"Sun am": "",
        //"Sun pm": "",
        //"Closure": "",

        public string Agency { get; set; }

        //"Facilities": "http://www.alexandrahillssc.com.au/",
        //"Description": "",
        //"Operating hours": "Monday, 10am - 12pm and Thursday 5:30pm - 7:30pm",
        //"Operating days": "Mon,Thurs,"
    }
}