using Newtonsoft.Json;

namespace Appointments.Entity.DTO
{
    public class DoctorDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("firstname")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("medicalRecord")]

        public Dictionary<string, string> MedicalRecord;

        [JsonProperty("emergencyContactName")]
        public string EmergencyContactName { get; set; }

        [JsonProperty("emergencyContactNumber")]
        public string EmergencyContactNumber { get; set; }

        [JsonProperty("speciality")]
        public string Speciality { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("licenseNumber")]
        public string LicenseNumber { get; set; }

        [JsonProperty("boardCertification")]
        public string BoardCertifiicate { get; set; }

        [JsonProperty("hospitalAffiliation")]
        public string HosptalAffliation { get; set; }

        [JsonProperty("schedule")]
        public Dictionary<string, DateTime> schedule { get; set; }

        [JsonProperty("patients")]
        public Dictionary<string, string> Patients { get; set; }
    }
}
