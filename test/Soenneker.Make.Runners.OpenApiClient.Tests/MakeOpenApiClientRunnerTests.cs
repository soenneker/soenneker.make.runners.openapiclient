using Soenneker.Tests.HostedUnit;

namespace Soenneker.Make.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class MakeOpenApiClientRunnerTests : HostedUnitTest
{
    public MakeOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
