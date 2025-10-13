using Ati.API.Common.Attributes;
using Ati.API.Common.Services.Interfaces;
using System.Security.Claims;

namespace Ati.API.Common.Services;

[Injectable]
public class ProfileContextService : IProfileContextService
{
    public string GetCurrentProfileId(ClaimsPrincipal user)
    {
        var email = user.FindFirstValue(ClaimTypes.Email);
        if (string.IsNullOrEmpty(email))
            throw new InvalidOperationException("No email claim found for authenticated user.");
        return $"profiles/{email}";
    }
}