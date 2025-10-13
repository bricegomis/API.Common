using Ati.API.Common.Models.Dto;
using Ati.API.Common.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ati.API.Common.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class ProfileController(
    IProfileService profileService,
    IProfileContextService profileContext) : ControllerBase
{
    private readonly IProfileService _profileService = profileService;
    private readonly IProfileContextService _profileContext = profileContext;

    [HttpGet]
    public async Task<ActionResult<ProfileDto>> Get()
    {
        var profileId = _profileContext.GetCurrentProfileId(User);
        var profile = await _profileService.GetCurrentProfileAsync(profileId);
        if (profile == null)
            return NotFound();
        return Ok(profile);
    }
}