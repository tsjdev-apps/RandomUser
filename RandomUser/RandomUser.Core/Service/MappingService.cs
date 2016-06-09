using System.Collections.Generic;
using System.Linq;
using RandomUser.Core.DTO;
using RandomUser.Core.ExtensionMethods;
using RandomUser.Core.Interfaces.Service;
using RandomUser.Core.Model;

namespace RandomUser.Core.Service
{
    public class MappingService : IMappingService
    {
        public IEnumerable<User> MapUsers(IEnumerable<Result> dtos)
        {
            var models = from dto in dtos
                         select MapUser(dto);

            return models;
        }

        private User MapUser(Result dto)
        {
            var model = new User();

            if (dto == null)
                return null;

            if (dto.Name != null)
            {
                model.FirstName = dto.Name.First.FirstCharToUpper();
                model.LastName = dto.Name.Last.FirstCharToUpper();
            }

            if (dto.Picture != null)
            {
                model.PictureUrl = dto.Picture.Large;
            }

            model.Gender = dto.Gender;
            model.Cell = dto.Cell;
            model.Phone = dto.Phone;
            model.Email = dto.Email;

            return model;
        }
    }
}