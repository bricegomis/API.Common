using Ati.API.Common.Models.Documents.Interfaces;

namespace Ati.API.Common.Models.Documents;

public class ProfileDocument : IDateTracked
{
    public required string Id { get; set; }
    public required string Email { get; set; }
    public string? AvatarUrl { get; set; }
    public string? DisplayName { get; set; }
    public DateTimeOffset DateLastConnection { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset DateModified { get; set; }
}
