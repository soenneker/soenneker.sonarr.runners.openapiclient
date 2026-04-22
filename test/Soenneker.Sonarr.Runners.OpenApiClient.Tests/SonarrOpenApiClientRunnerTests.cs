using Soenneker.Tests.HostedUnit;

namespace Soenneker.Sonarr.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SonarrOpenApiClientRunnerTests : HostedUnitTest
{
    public SonarrOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
