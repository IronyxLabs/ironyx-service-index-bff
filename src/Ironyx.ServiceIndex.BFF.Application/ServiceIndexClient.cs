using Ironyx.Kernel.Execution.Senders;
using Ironyx.ServiceIndex.BFF.Application.Models;

namespace Ironyx.ServiceIndex.BFF.Application
{
    public class ServiceIndexClient : IServiceIndexClient
    {
        private readonly IRequestSender _sender;

        public ServiceIndexClient(IRequestSender sender)
        {
            _sender = sender;
        }

        public async Task<Overview> GetOverviewAsync(CancellationToken cancellationToken)
        {
            var services = await _sender.GetAsync<GetRegistrationsQuery, IEnumerable<GetRegistrationsQuery.Result>>(new GetRegistrationsQuery(), cancellationToken);

            return new Overview { ServiceCount = services!.Count() };
        }
    }
}
