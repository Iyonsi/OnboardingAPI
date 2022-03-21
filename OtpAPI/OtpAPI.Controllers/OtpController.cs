using Microsoft.AspNetCore.Mvc;
using OtpApi.Commons.Helpers;
using OtpAPI.OtpAPI.Services.Interfaces;
using System.Threading.Tasks;

namespace OtpApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class OtpController : ControllerBase
    {
        private readonly IOtpApiService _otpApiService;

        public OtpController(IOtpApiService otpApiService)
        {
            _otpApiService = otpApiService;
        }

        [HttpPost("verify-phone-number{Id}")]
        public async Task<IActionResult> VerifyPhoneNumber([FromRoute] string id, string phoneNumber)
        {
            var unVerifiedNumber = await _otpApiService.VerifyPhoneNumber(id, phoneNumber);
            if (unVerifiedNumber == null)
            {
                ModelState.AddModelError("Not found", "");
                return NotFound(ResponseHelper.BuildResponse<object>(false, "Account Doesn't Exist", ModelState, null));
            }
            return Ok(ResponseHelper.BuildResponse<object>(true, "An Otp Has Been Sent To Your Phone Number", ResponseHelper.NoErrors, unVerifiedNumber));
        }
    }
}
