using System.Security.Claims;

namespace Ati.API.Common.Services.Interfaces;

public interface IProfileContextService
{
    /// <summary>
    /// Retrieves the profileId from the current ClaimsPrincipal (e.g., "profiles/user@email.com").
    /// </summary>
    string GetCurrentProfileId(ClaimsPrincipal user);
}