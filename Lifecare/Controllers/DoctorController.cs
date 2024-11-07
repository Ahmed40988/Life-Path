using Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lifecare.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorController : ApiBaseController
{

  public DoctorController(IUnitOfWork unitOfWork) : base(unitOfWork)
   {        }
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok();
    }

}
