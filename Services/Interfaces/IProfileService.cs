using System.Security.Claims;
using Ati.API.Common.Models.Dto;

namespace Ati.API.Common.Services.Interfaces;

public interface IProfileService
{
    Task<ProfileDto?> GetCurrentProfileAsync(string profileId);
    Task<ProfileDto?> GetProfileFromEmailAsync(string email);
    /// <summary>
    /// Retrieves the profileId from the current ClaimsPrincipal (e.g., "profiles/user@email.com").
    /// </summary>
    string GetCurrentProfileId(ClaimsPrincipal user);
}