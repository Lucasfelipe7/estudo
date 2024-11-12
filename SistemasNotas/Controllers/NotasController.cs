using Microsoft.AspNetCore.Mvc;
using SistemasNotas.Entities;
using SistemasNotas.Services;

namespace SistemasNotas.Controllers;


[ApiController]
[Route("api/[controller]")]

public class NotasController: ControllerBase
{
    public readonly NotasService _notasService;
    public NotasController(NotasService notasService)
    {
        _notasService = notasService;
    }  
    
    [HttpPost]
    public IActionResult Post([FromBody] Aluno body)
    {
        var calcularConceito = _notasService.CalcularConceito(body);
        return Ok(calcularConceito);
    }

    /*[HttpGet]
    public IActionResult Get()
    {
        return Ok(_notasService.);
    }*/
    

}


