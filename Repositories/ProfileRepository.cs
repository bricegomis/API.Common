using Ati.API.Common.Attributes;
using Ati.API.Common.Models.Documents;
using Ati.API.Common.Repositories.Interfaces;
using Raven.Client.Documents;
using Raven.Client.Documents.Session;

namespace Ati.API.Common.Repositories;

[Injectable]
public class ProfileRepository(IAsyncDocumentSession session) : IProfileRepository
{
    public async Task<ProfileDocument?> GetByIdAsync(string id)
    {
        return await session.LoadAsync<ProfileDocument>(id);
    }

    public async Task<ProfileDocument?> GetByEmailAsync(string id)
    {
        return await session.Query<ProfileDocument>()
            .FirstOrDefaultAsync(x => x.Email == id);
    }
}