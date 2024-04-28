using Volo.Abp.Settings;

namespace OptiField.Settings;

public class OptiFieldSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(OptiFieldSettings.MySetting1));
    }
}
