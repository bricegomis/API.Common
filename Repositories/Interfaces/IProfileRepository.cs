using Ati.API.Common.Models.Documents;

namespace Ati.API.Common.Repositories.Interfaces;

public interface IProfileRepository
{
    Task<ProfileDocument?> GetByIdAsync(string id);
    Task<ProfileDocument?> GetByEmailAsync(string email);
}