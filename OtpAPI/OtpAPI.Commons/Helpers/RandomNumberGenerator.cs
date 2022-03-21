using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtpApi.Commons.Helpers
{
    public class RandomNumberGenerator
    {
        public string GenerateRandomNumber()
        {
            Random random = new Random();
            return random.Next(999999).ToString();
        }
    }


}
