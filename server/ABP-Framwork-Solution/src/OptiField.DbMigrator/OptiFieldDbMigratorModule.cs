using OptiField.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace OptiField.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OptiFieldEntityFrameworkCoreModule),
    typeof(OptiFieldApplicationContractsModule)
    )]
public class OptiFieldDbMigratorModule : AbpModule
{
}
