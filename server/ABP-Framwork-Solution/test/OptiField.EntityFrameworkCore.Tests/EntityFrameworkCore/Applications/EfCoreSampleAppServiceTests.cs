using OptiField.Samples;
using Xunit;

namespace OptiField.EntityFrameworkCore.Applications;

[Collection(OptiFieldTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OptiFieldEntityFrameworkCoreTestModule>
{

}
