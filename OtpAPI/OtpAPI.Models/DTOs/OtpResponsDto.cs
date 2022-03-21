using Microsoft.AspNetCore.Identity;

namespace OtpAPI.OtpAPI.Models.DTOs
{
    public class OtpResponsDto
    {
        public string Tag { get; set; }
        public string Key { get; set; }
        public string Message { get; set; }
        public IdentityResult ErrorResult { get; set; }
        public OtpGeneratedDto Otp { get; set; }
    }
}
