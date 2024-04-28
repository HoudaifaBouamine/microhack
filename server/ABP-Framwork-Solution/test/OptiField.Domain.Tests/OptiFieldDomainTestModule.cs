using Volo.Abp.Modularity;

namespace OptiField;

[DependsOn(
    typeof(OptiFieldDomainModule),
    typeof(OptiFieldTestBaseModule)
)]
public class OptiFieldDomainTestModule : AbpModule
{

}
