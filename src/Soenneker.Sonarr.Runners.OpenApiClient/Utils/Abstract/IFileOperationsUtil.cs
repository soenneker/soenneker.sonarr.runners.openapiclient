using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Sonarr.Runners.OpenApiClient.Utils.Abstract;

public interface IFileOperationsUtil
{
    ValueTask Process(CancellationToken cancellationToken = default);
}
