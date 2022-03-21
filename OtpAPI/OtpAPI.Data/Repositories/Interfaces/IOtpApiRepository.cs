using OtpAPI.OtpAPI.Models;
using System.Threading.Tasks;

namespace OtpAPI.OtpAPI.Data.Repositories.Interfaces
{
    public interface IOtpApiRepository
    {
        Task<OtpUser> GetUser(string id);
    }
}
