using Xunit;

namespace OptiField.EntityFrameworkCore;

[CollectionDefinition(OptiFieldTestConsts.CollectionDefinitionName)]
public class OptiFieldEntityFrameworkCoreCollection : ICollectionFixture<OptiFieldEntityFrameworkCoreFixture>
{

}
