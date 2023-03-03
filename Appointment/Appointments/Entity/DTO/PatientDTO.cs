using Newtonsoft.Json;

namespace Appointments.Entity.DTO
{
    public class PatientDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("patientFirstName")]

        public string PatientFirstName { get; set; }

        [JsonProperty("PatientlastName")]
        public string PatientLastName { get; set; }

        [JsonProperty("medicalRecord")]

        public Dictionary<string, string> MedicalRecord { get; set; }

        [JsonProperty("emergencyContactName")]
        public string EmergencyContactName  { get; set; }

        [JsonProperty("emergencyContactNumber")]
        public string EmergencyContactNumber { get; set; }

        [JsonProperty("age")]
        public int Age  { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("drName")]
        public Dictionary<string,string> DrName { get; set; }



    }
}
