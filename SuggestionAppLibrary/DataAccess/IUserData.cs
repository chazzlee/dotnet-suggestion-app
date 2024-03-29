using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuggestionAppLibrary.DataAccess;

public interface IUserData
{
    Task CreateUser(UserModel user);
    Task<UserModel> GetUserAsync(string id);
    Task<UserModel> GetUserFromAuthenticationAsync(string objectId);
    Task<List<UserModel>> GetUsersAsync();
    Task UpdateUser(UserModel user);
}
