using Ati.API.Common.Models.Documents;
using Ati.API.Common.Models.Dto;

namespace Ati.API.Common.Mapping.Interfaces;

public interface IProfileMapper
{
    ProfileDto ToDto(ProfileDocument doc);
}