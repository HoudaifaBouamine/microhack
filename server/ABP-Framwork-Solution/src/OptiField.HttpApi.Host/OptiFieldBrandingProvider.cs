using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace OptiField;

[Dependency(ReplaceServices = true)]
public class OptiFieldBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "OptiField";
}
