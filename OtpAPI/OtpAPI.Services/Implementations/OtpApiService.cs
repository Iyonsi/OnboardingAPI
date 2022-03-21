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
        private readonly RandomNumberGenerator _randomNumberGenerator;

        public OtpApiService(IOtpApiRepository otpApiRepository, RandomNumberGenerator randomNumberGenerator)
        {
            _otpApiRepository = otpApiRepository;
            _randomNumberGenerator = randomNumberGenerator;
        }

        public async Task<OtpUserToReturnDto> VerifyPhoneNumber(string id, string phoneNumber)
        {
            var UnVerifiedNumber = await _otpApiRepository.GetUser(id);
            if (UnVerifiedNumber.PhoneNumber != phoneNumber)
                return null;
            var otp = _randomNumberGenerator.GenerateRandomNumber();

            OtpUserToReturnDto returnDto = new OtpUserToReturnDto()
            {
                Id = UnVerifiedNumber.Id,
                PhoneNumber = UnVerifiedNumber.PhoneNumber,
                UserName = UnVerifiedNumber.UserName,
                Otp = otp,
            };
            return returnDto;

        }
    }

}     
               
    

