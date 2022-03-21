using Microsoft.EntityFrameworkCore;
using OtpAPI.OtpAPI.Data.Repositories.Interfaces;
using OtpAPI.OtpAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace OtpAPI.OtpAPI.Data.Repositories.Implementations
{
    public class OtpApiRepository : IOtpApiRepository
    {
        private readonly OtpApiDbContext _context;
        public OtpApiRepository(OtpApiDbContext context)
        {
            _context = context;
        }

        public async Task<OtpUser> GetUser(string id)
        {
            return _context.OtpUsers.Find(id);
        }
    }
}
