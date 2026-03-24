using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Sonarr.Runners.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SonarrOpenApiClientRunnerTests : FixturedUnitTest
{
    public SonarrOpenApiClientRunnerTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
