using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using RandomUser.Core.Model;

namespace RandomUser.Core.Interfaces.Repository
{
    public interface IUserRepository
    {
        event EventHandler<User> SelectedUserChanged;

        Task<ObservableCollection<User>> GetUsersAsync();
        void SearchUsers(string query);
        void SetSelectedUser(User user);
    }
}