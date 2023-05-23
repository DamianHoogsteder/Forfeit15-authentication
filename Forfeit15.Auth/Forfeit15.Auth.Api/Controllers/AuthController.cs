using Forfeit15.Auth.Core.Api.Services.UserMetaData;
using Forfeit15.Postgres.Models.UserMetaData;
using Microsoft.AspNetCore.Mvc;

namespace Forfeit15.Auth.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserMetaDataService _userMetaDataService;

    public AuthController(IUserMetaDataService userMetaDataService)
    {
        _userMetaDataService = userMetaDataService;
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    public async Task<IActionResult> ProcessUserMetaData(UserMetaDataViewmodel userMetaData, CancellationToken cancellationToken)
    {
        return Ok( await _userMetaDataService.AuthenticateUser(userMetaData, cancellationToken));
    }
} 