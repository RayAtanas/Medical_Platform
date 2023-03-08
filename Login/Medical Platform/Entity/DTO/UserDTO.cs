using Medical_Platform.Entity;
using Newtonsoft.Json;

namespace Medical_Platform.DTO
{
    public class UserDTO
    {
        

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("firstname")]
        public string? FirstName { get; set; }

        [JsonProperty("lastname")]
        public string? LastName { get; set; }

        [JsonProperty("phonenumber")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("medicalRecord")]
        public Dictionary<string, string>? Medical_Record { get; set; }
    }
}
