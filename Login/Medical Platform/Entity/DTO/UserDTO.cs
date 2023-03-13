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

        [JsonProperty("userName")]
        public string? Username { get; set; }

        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [JsonProperty("lastName")]
        public string? LastName { get; set; }

        [JsonProperty("phoneNumber")]
        public string? PhoneNumber { get; set; }

        [JsonProperty("medicalRecord")]
        public List<string>? Medical_Record { get; set; }
    }
}
