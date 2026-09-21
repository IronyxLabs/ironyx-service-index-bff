using Ironyx.ServiceIndex.BFF.Application.Models;

namespace Ironyx.ServiceIndex.BFF.Application
{
    public interface IServiceIndexClient
    {
        Task<Overview> GetOverviewAsync(CancellationToken cancellationToken);
    }
}
