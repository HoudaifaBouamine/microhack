using Volo.Abp.Modularity;

namespace OptiField;

public abstract class OptiFieldApplicationTestBase<TStartupModule> : OptiFieldTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
