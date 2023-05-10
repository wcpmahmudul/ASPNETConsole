using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthCheck.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SqlHealthCheck : ControllerBase
    {
    }
}
