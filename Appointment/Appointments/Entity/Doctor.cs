using Appointments.Entity;

namespace Appointments.Entity
{
    public class Doctor:BaseEntity
    {
        public string firstName { get; set; }

        public string lastName { get; set; }

        public Dictionary<string, string> medicalRecord;

        public string emergencyContactName { get; set; }

        public string emergencyContactNumber { get; set; }

        public string speciality { get; set; }

        public int age { get; set; }

        public string gender { get; set; }

        public string nationality { get; set; }
         
        public string licenseNumber { get; set; }

        public string boardCertification { get; set; }

        public string hospitalAffiliation { get; set; }

        public AppointmentCalendar schedule { get; set; }

        public Dictionary<string, string> satients { get; set; }



    }
}
