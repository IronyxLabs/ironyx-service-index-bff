using Ironyx.ServiceIndex.BFF.Application;
using Ironyx.ServiceIndex.BFF.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ironyx.ServiceIndex.BFF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServiceIndexClient _client;

        public ServicesController(IServiceIndexClient client)
        {
            _client = client;
        }

        [HttpGet("overview")]
        public async Task<Overview> GetOverviewAsync(CancellationToken cancellationToken)
        {
            return await _client.GetOverviewAsync(cancellationToken);
        }
    }
}
