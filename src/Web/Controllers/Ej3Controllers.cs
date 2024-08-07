using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class Ej3Controller : ControllerBase{
    [HttpGet]
    public string Get(string name, string age){
        return $"Te llamas {name} y tenes {age} años";
    }
}