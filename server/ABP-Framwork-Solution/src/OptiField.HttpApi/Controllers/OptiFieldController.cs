using OptiField.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace OptiField.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OptiFieldController : AbpControllerBase
{
    protected OptiFieldController()
    {
        LocalizationResource = typeof(OptiFieldResource);
    }
}
