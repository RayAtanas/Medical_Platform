namespace Appointments.Entity
{
    public class Patient:BaseEntity
    {


        public string firstName { get; set; }

        public string lastName { get; set; }

        public  Dictionary<string, string> medicalRecord;

        public string emergencyContactName { get; set; }

        public string emergencyContactNumber { get; set; }

        public int age { get; set; }

        public string gender { get; set; }

        public string nationality { get; set; }

        public Dictionary<string,string> drName { get; set; }


        

    }
}
