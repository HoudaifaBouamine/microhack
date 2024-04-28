using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OptiField.Data;
using Volo.Abp.DependencyInjection;

namespace OptiField.EntityFrameworkCore;

public class EntityFrameworkCoreOptiFieldDbSchemaMigrator
    : IOptiFieldDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOptiFieldDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the OptiFieldDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OptiFieldDbContext>()
            .Database
            .MigrateAsync();
    }
}
