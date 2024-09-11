using LanosCertifiedStore.Persistence.Contexts.ApplicationDatabaseContext;

namespace LanosCertifiedStore.Persistence.Commands.Common;

public sealed class SaveChangesCommand(ApplicationDatabaseContext context)
{
    public async Task<int> Execute(CancellationToken cancellationToken)
    {
       return await context.SaveChangesAsync(cancellationToken);
    }
}