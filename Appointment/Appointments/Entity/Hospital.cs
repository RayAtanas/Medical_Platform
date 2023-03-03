namespace Appointments.Entity
{
    public class Hospital:BaseEntity
    {

        public string hospitalName { get; set; }

        public string hospitalLocation { get; set; }

        public string hospitalCode  { get; set; }

        public string hospitalId { get; set; }

        public bool isAvailable { get; set; }

        public Dictionary<int,string> departments { get; set; }  

        public bool? hasIsolationRoom { get; set; }



    }
}
