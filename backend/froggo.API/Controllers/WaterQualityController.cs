using froggo.API.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace froggo.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WaterQualityController : Controller
{
    private readonly IWaterQualityRepository _db;

    public WaterQualityController(IWaterQualityRepository db)
    {
        _db = db;   
    }
    
    // [HttpGet]
    // [ProducesResponseType(StatusCodes.Status403Forbidden)]
    // [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    // [ProducesResponseType(StatusCodes.Status200OK)]
    
}