using System.Threading.Tasks;

namespace OptiField.Data;

public interface IOptiFieldDbSchemaMigrator
{
    Task MigrateAsync();
}
