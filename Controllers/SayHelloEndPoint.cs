using Microsoft.AspNetCore.Mvc;

namespace SayHelloEndPoint.Controllers;

[ApiController] 
[Route("api/[controller]")] 
public class SayHelloEndPointController : ControllerBase
{

[HttpGet]
[Route("GetName/{userInput}")]

public string GetName(string userInput)
{
    return ("what's going on " + userInput);
}

}