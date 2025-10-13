using Ati.API.Common.Attributes;
using Ati.API.Common.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Ati.API.Common.Services;

[Injectable(ServiceLifetime.Singleton)]
public class DateTimeService : IDateTimeService
{
    public DateTimeOffset GetNow()
    {
        return DateTimeOffset.UtcNow;
    }
}