using Appointments.Entity;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Appointments.Entity
{
    
   public class Appointment:BaseEntity
    {
        public string appointmentId { get; set; }
        
        public DateTime startTime { get; set; }
        
        public DateTime endTime { get; set; }
        public string doctorId { get; set; }

        public string patientId  { get; set; }

        public string location { get; set; }
        
        public int price { get; set; }

        public string status { get; set; }

        public string title { get; set; }



    }
   public class AppointmentCalendar:Appointment
    {

        string Id { get; set; }

        string DoctorId { get; set; }

        string PatientId { get; set; }

        Dictionary<string, Dictionary<string, Appointment>> AppointmentCal { get; set; }
    }

   
}
