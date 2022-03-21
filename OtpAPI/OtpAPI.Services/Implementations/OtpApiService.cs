using OtpApi.Commons.Helpers;
using OtpAPI.OtpAPI.Data.Repositories.Interfaces;
using OtpAPI.OtpAPI.Models.DTOs;
using OtpAPI.OtpAPI.Services.Interfaces;
using System.Threading.Tasks;

namespace OtpAPI.OtpAPI.Services.Implementations
{
    public class OtpApiService : IOtpApiService
    {
        private readonly IOtpApiRepository _otpApiRepository;

        public OtpApiService(IOtpApiRepository otpApiRepository )
        {
            _otpApiRepository = otpApiRepository;
        }

        public async Task<OtpUserToReturnDto> VerifyPhoneNumber(string id, string phoneNumber)
        {
            var unVerifiedNumber = await _otpApiRepository.GetUser(id);
            if (unVerifiedNumber == null) 
                return null;
            var otp = RandomNumberGenerator.GenerateRandomNumber();

            OtpUserToReturnDto returnDto = new OtpUserToReturnDto()
            {
                Id = unVerifiedNumber.Id,
                PhoneNumber = unVerifiedNumber.PhoneNumber,
                UserName = unVerifiedNumber.UserName,
                Otp = otp,
            };
            return returnDto;

        }
    }

}     
               
    

