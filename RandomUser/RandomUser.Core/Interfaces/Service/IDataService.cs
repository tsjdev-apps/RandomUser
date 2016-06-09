using System.Collections.Generic;
using System.Threading.Tasks;
using RandomUser.Core.Model;
using RandomUser.Core.Utils;

namespace RandomUser.Core.Interfaces.Service
{
    public interface IDataService
    {
        Task<DataServiceResponse<IEnumerable<User>>> GetUsersAsync(int count);
    }
}