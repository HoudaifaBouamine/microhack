using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace OptiField.Data;

/* This is used if database provider does't define
 * IOptiFieldDbSchemaMigrator implementation.
 */
public class NullOptiFieldDbSchemaMigrator : IOptiFieldDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
