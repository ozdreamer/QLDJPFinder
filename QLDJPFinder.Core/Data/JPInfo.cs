using Newtonsoft.Json;

namespace QLDJPFinder.Core
{
    public class JPInfo
    {
        [JsonProperty("_id")]
        public int Id { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Location")]
        public string Location { get; set; }

        [JsonProperty("Services")]
        public string Services { get; set; }

        [JsonProperty("Office type")]
        public string OfficeType { get; set; }

        [JsonProperty("Counter type")]
        public string CounterType { get; set; }

        [JsonProperty("Address 1")]
        public string Address1 { get; set; }

        [JsonProperty("Address 2")]
        public string Address2 { get; set; }

        [JsonProperty("Suburb")]
        public string Suburb { get; set; }

        [JsonProperty("Postcode")]
        public int PostCode { get; set; }

        [JsonProperty("Postal address 1")]
        public string PostalAddress1 { get; set; }

        [JsonProperty("Postal address 2")]
        public string PostalAddress2 { get; set; }

        [JsonProperty("Postal suburb")]
        public string PostalSuburb { get; set; }

        [JsonProperty("Postal postcode")]
        public string PostalPostCode { get; set; }

        [JsonProperty("Latitude")]
        public double Latitude { get; set; }

        [JsonProperty("Longitude")]
        public double Longitude { get; set; }

        [JsonProperty("Phone")]
        public string Phone { get; set; }

        [JsonProperty("Fax")]
        public string Fax { get; set; }

        [JsonProperty("Email")]
        public string Email { get; set; }

        [JsonProperty("Agency")]
        public string Agency { get; set; }

        [JsonProperty("Facilities")]
        public string Facilities { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("Operating hours")]
        public string OperatingHours { get; set; }

        [JsonProperty("Operating days")]
        public string OperatingDays { get; set; }
    }
}