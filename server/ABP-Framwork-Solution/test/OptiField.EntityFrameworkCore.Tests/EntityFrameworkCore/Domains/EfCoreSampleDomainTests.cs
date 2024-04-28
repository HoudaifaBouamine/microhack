using OptiField.Samples;
using Xunit;

namespace OptiField.EntityFrameworkCore.Domains;

[Collection(OptiFieldTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OptiFieldEntityFrameworkCoreTestModule>
{

}
