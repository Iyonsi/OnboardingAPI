using Microsoft.AspNetCore.Identity;

namespace OtpAPI.OtpAPI.Models.DTOs
{
    public class OtpGeneratedDto
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Otp { get; set; }
    }
}
