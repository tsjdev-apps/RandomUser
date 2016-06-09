using System.Collections.Generic;
using RandomUser.Core.DTO;
using RandomUser.Core.Model;

namespace RandomUser.Core.Interfaces.Service
{
    public interface IMappingService
    {
        IEnumerable<User> MapUsers(IEnumerable<Result> dtos);
    }
}