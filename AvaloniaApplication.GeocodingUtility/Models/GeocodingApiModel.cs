using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace AvaloniaApplication.GeocodingUtility.Models;

public class GeocodingApiModel
{
        [JsonProperty("results")]
        public List<ApiModel> Result { get; set; }
        [JsonProperty("generationtime_ms")]
        public double GenerationTime { get; set; }
}

public class ApiModel
{
        [JsonProperty("id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("elevation")]
        public float Elevation { get; set; }
        [JsonProperty("feature_code")]
        public string FeatureCode { get; set; }
        [JsonProperty("country_code")]
        public string CountryCode { get; set; }
        [JsonProperty("admin1_id")]
        public int Admin1ID { get; set; }
        [JsonProperty("admin2_id")]
        public int Admin2ID { get; set; }
        [JsonProperty("admin3_id")]
        public int Admin3ID { get; set; }
        [JsonProperty("admin4_id")]
        public int Admin4ID { get; set; }
        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
        [JsonProperty("population")]
        public int Population { get; set; }
        [JsonProperty("country_id")]
        public int CountryID { get; set; }
        [JsonProperty("country")]
        public string Country { get; set; }
        [JsonProperty("admin1")]
        public string Admin1 { get; set; }
        [JsonProperty("admin2")]
        public string Admin2 { get; set; }
        [JsonProperty("admin3")]
        public string Admin3 { get; set; }
        [JsonProperty("admin4")]
        public string Admin4 { get; set; }
}