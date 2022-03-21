using OtpAPI.OtpAPI.Models.DTOs;
using System.Threading.Tasks;

namespace OtpAPI.OtpAPI.Services.Interfaces
{
    public interface IOtpApiService
    {
        Task<OtpUserToReturnDto> VerifyPhoneNumber(string id, string phoneNumber);
    }
}
