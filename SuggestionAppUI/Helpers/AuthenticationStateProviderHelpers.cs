using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace SuggestionAppUI.Helpers;

public static class AuthenticationStateProviderHelpers
{
    public static async Task<UserModel> GetUserFromAuthAsync(
        this AuthenticationStateProvider provider,
        IUserData userData
    )
    {
        var authState = await provider.GetAuthenticationStateAsync();
        var objectId = authState.User.Claims.FirstOrDefault(claim => claim.Type.Contains("objectidentifier"))?.Value;
        return await userData.GetUserFromAuthenticationAsync(objectId ?? String.Empty);
    }
}