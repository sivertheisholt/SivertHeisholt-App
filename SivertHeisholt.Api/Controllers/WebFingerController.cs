using Microsoft.AspNetCore.Mvc;

namespace SivertHeisholt.Api.Controllers;

[ApiController]
[Route("/.well-known/webfinger")]
public class WebFingerController : ControllerBase
{
  [HttpGet]
  public IActionResult Get([FromQuery] string resource)
  {
    var response = new
    {
      subject = resource,
      links = new[]
        {
                new
                {
                    rel = "http://openid.net/specs/connect/1.0/issuer",
                    href = "https://auth.sivertheisholt.no"
                }
            }
    };

    return Ok(response);
  }
}
