namespace Medical_Platform.Entity
{
    public class User : BaseEntity
    {
        public string email { get; set; }
        public string password { get; set; }

        public bool isBlocked = false;

        public string? username { get; set; }

        public string? firstName { get; set; }

        public string? lastName { get; set; }

        public string? phoneNumber { get; set; }

        public int? attempt { get; set; }

        public DateTime timeBlocked { get; set; }

        public Dictionary<string, string>? medical_Record { get; set; }
        

    }

}
