using Volo.Abp.Modularity;

namespace OptiField;

[DependsOn(
    typeof(OptiFieldApplicationModule),
    typeof(OptiFieldDomainTestModule)
)]
public class OptiFieldApplicationTestModule : AbpModule
{

}
