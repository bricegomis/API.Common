using Ati.API.Common.Models.Dto;
using Ati.API.Common.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Ati.API.Common.Controllers;

[Route("[controller]")]
[ApiController]
[Authorize]
public class ProfileController(
    IProfileService profileService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<ProfileDto>> Get()
    {
        var profileId = profileService.GetCurrentProfileId(User);
        var profile = await profileService.GetCurrentProfileAsync(profileId);
        if (profile == null)
            return NotFound();
        return Ok(profile);
    }
}