using Ati.API.Common.Models.Dto;

namespace Ati.API.Common.Services.Interfaces;

public interface IProfileService
{
    Task<ProfileDto?> GetCurrentProfileAsync(string profileId);
    Task<ProfileDto?> GetProfileFromEmailAsync(string email);
}