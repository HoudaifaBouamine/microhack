using Volo.Abp.Modularity;

namespace OptiField;

/* Inherit from this class for your domain layer tests. */
public abstract class OptiFieldDomainTestBase<TStartupModule> : OptiFieldTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
