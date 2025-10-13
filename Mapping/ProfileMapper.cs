using Ati.API.Common.Models.Documents;
using Ati.API.Common.Models.Dto;
using Riok.Mapperly.Abstractions;
using Ati.API.Common.Attributes;
using Ati.API.Common.Mapping.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Ati.API.Common.Mapping;

[Injectable(ServiceLifetime.Singleton)]
[Mapper]
public partial class ProfileMapper : IProfileMapper
{
    public partial ProfileDto ToDto(ProfileDocument doc);
}