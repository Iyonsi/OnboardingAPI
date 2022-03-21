namespace OtpAPI.OtpAPI.Models
{
    public class Otp
    {
        public string Id { get; set; }
        public string OtpCode { get; set; }
        public OtpUser OtpUser { get; set; }
        public string OtpCounter { get; set; }
    }
}
