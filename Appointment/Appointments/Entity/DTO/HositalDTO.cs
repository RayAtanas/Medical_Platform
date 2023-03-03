using Newtonsoft.Json;

namespace Appointments.Entity.DTO
{
    public class HositalDTO
    {
        [JsonProperty("hospitalId")]
        public string HositalId { get; set; }

        [JsonProperty("Name")]
        public string  HospitalName { get; set; }

        [JsonProperty("HospitalCode")]
        public string HospitalCode { get; set; }

        [JsonProperty("hospitallocation")]
        public string HospitalLocation { get; set; }

        [JsonProperty("isAvailable")]
        public bool ? IsAvailable { get; set; }

        [JsonProperty("departments")]
        public Dictionary<int,string> Departments { get; set; }

        [JsonProperty("hasIsolationRoom")]
        public bool? HasIsolationRoom { get; set; }



    }
}
