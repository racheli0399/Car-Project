using home2;
using home2.Core.Service;
using home2.Entitis;
using home2.Serivce;
using home2.Service;
using Microsoft.AspNetCore.Mvc;
using static SellersController;

[Route("api/[controller]")]
[ApiController]
public class TurnsController : ControllerBase
{
    private readonly ITurnsService _turnsService;

    public TurnsController(ITurnsService turnsService)
    {
        _turnsService = turnsService;
    }
  

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_turnsService.GetList);

    }
    [HttpGet("{id}")]
    public ActionResult<Turn> GetById(string id)
    {
        var turn = _turnsService.GetById(id);
        if (turn != null)
        {
            return Ok(turn);
        }
        return NotFound();
    }

    [HttpPost]
    public Turn Post([FromBody] Turn value)
    {
         var turn = _turnsService.GetById(value.id);
        if (turn != null)
        {
            return Conflict();
        }
            _turnsService.Post(value);
            return Ok();
        

    }

    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] Turn value)
    {
        var turn = _turnsService.GetbyId(id);
        if (turn != null)
        {
            return Conflite();
        }
        _turnsService.Put(value);
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(string id)
    {
        var index = _context.Turn.FindIndex(e => e.Id == id);
        if (index >= 0)
        {
            _context.Turn.RemoveAt(index);
            return NoContent();
        }
        return NotFound();
    }

}
