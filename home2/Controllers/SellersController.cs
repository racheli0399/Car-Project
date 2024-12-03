using home2;
using home2.Core.Service;
using home2.Entitis;
using home2.Service;
using Microsoft.AspNetCore.Mvc;
using static CustomersController;

[Route("api/[controller]")]
[ApiController]
public class SellersController : ControllerBase
{
    private readonly ISellersService _sellersService;

    public SellersController(ISellersService sellersService)
    {
        _sellersService = sellersService;
    }
    [HttpGet]
    public IEnumerable<Seller> Get()
    {
        return Ok(_sellersService.GetList);
    }
    [HttpGet("{id}")]
    public ActionResult<Seller> GetById(string id)
    {
        var seller = _sellersService.GetById(id);
        if (seller != null)
        {
            return Ok(seller);
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult Post([FromBody] Seller value)
    {
        var seller = _sellersService.GetById(id);
        if (seller != null)
        {
            return Conflict();
        }
        _sellersService.Post(value);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(string id, [FromBody] Seller value)
    {
        var index = _sellersService.GetById( id);
        if (index == null)
        {
            return Conflict();
        }
        _sellersService.Put(value);
        return Ok();
    }
    public ActionResult PutStatus(string Id, bool IsActive)
    {
        var seller = _customersService.GetById(Id);
        if (seller == null)
        {
            return Conflict();
        }
        _customersService.PutStatus(Id, IsActive);
        return Ok();
    }

}
