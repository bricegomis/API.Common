using System.Security.Claims;
using Ati.API.Common.Attributes;
using Ati.API.Common.Models.Dto;
using Ati.API.Common.Mapping.Interfaces;
using Ati.API.Common.Services.Interfaces;
using Ati.API.Common.Repositories.Interfaces;

namespace Ati.API.Common.Services;

[Injectable]
public class ProfileService(IProfileRepository repo, IProfileMapper mapper) : IProfileService
{
    private readonly IProfileRepository _repo = repo;
    private readonly IProfileMapper _mapper = mapper;

    public async Task<ProfileDto?> GetCurrentProfileAsync(string profileId)
    {
        var doc = await _repo.GetByIdAsync(profileId);
        return doc is null ? null : _mapper.ToDto(doc);
    }
    
    public async Task<ProfileDto?> GetProfileFromEmailAsync(string email)
    {
        var doc = await _repo.GetByEmailAsync(email);
        return doc is null ? null : _mapper.ToDto(doc);
    }
    
    public string GetCurrentProfileId(ClaimsPrincipal user)
    {
        var email = user.FindFirstValue(ClaimTypes.Email);
        if (string.IsNullOrEmpty(email))
            throw new InvalidOperationException("No email claim found for authenticated user.");
        return $"profiles/{email}";
    }
}