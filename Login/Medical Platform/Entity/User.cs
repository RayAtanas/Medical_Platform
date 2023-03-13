namespace Medical_Platform.Entity
{
    public class User : BaseEntity
    {
        public string email { get; set; }
        public string password { get; set; }

        public bool isBlocked = false;

        public string? userName { get; set; }

        public string? firstName { get; set; }

        public string? lastName { get; set; }

        public string? phoneNumber { get; set; }

        public int? attempt { get; set; }

        public string? gender { get; set; }

        public string? nationality { get; set; }

        public string? emergencyContact { get; set; }

        public DateTime timeBlocked { get; set; }

        public Dictionary<string,List<string>>? medical_Record { get; set; }
        

    }

}
