using home2;
using home2.Core.Service;
using home2.Entitis;
using home2.Service;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly  ICustomersService _customersService;
      

  public CustomersController(ICustomersService customersService)
    {
        _customersService = customersService;
    }


    [HttpGet]
    public ActionResult<Customer> Get()
    {
        return Ok(_customersService.GetList());
    }

    [HttpGet("{id}")]
    public ActionResult GetById(string id)
    {
        var customer = _customersService.GetById( id);
        if (customer != null)
        {
            return Ok(customer);
        }
        return NotFound();
    }

    [HttpPost]
    public ActionResult Post([FromBody] Customer value)
    {
        var customer = _customersService.GetById(id);
        if (customer != null)
            return Conflict();
        _customersService.Post(customer);
        return Ok();
    }

    [HttpPut("{id}")]
    public ActionResult Put(string id, [FromBody] Customer value)
    {
        var customers = _customersService.GetById(id);
        if (customer = null)
        {
            return Conflict();
        }
        _customersService.Put(value);
        return Ok();
    }
    
    public ActionResult PutStatus(string Id , bool IsActive)
    {
        var cusromer = _customersService.GetById(Id);
        if(cusromer == null)
        {
            return Conflict();
        }
        _customersService.PutStatus(Id,IsActive);
        return Ok();
    }


}
