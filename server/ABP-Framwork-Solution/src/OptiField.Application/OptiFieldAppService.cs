using System;
using System.Collections.Generic;
using System.Text;
using OptiField.Localization;
using Volo.Abp.Application.Services;

namespace OptiField;

/* Inherit your application services from this class.
 */
public abstract class OptiFieldAppService : ApplicationService
{
    protected OptiFieldAppService()
    {
        LocalizationResource = typeof(OptiFieldResource);
    }
}
