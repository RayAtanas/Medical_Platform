using Newtonsoft.Json;

namespace Appointments.Entity.DTO
{
    public class AppointmentsDTO
    {
        [JsonProperty("appointmentId")]
        public string AppointmentId { get; set; }

        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }

        [JsonProperty("doctorId")]
        public string DoctorId { get; set; }

        [JsonProperty("patientId")]
        public string PatientId { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
