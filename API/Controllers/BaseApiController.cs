using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
//ruta
[Route("api/[controller]")] // /api/users

public class BaseApiController : ControllerBase
{

}
