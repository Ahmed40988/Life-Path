using DTO;
using Interfaces;
using Lifepath.Entities.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Lifecare.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorController : ApiBaseController
{

  public DoctorController(IUnitOfWork unitOfWork) : base(unitOfWork)
   {        }
    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var doc=_unitOfWork.Doctors.GetAll().Select(x=>new DoctorDto
        {
            DoctorName = x.DoctorName,
            SpecializationID = x.SpecializationID,
            ImgUrl = x.ImgUrl,
            Price=x.Price,
            Bio=x.Bio,
            Email=x.Email,
            AvailableDays=x.AvailableDays,
            Rating=x.Rating,
            Address=x.Adress,
            IsActive=x.IsActive,
            PhoneNumber=x.PhoneNumber,  

        }).ToList();
        return Ok(doc);
    }
    [HttpGet("ByName")]
    public IActionResult GetByName(string Name)
    {
        var doc1 = _unitOfWork.Doctors.FindAll(s => s.DoctorName.Contains(Name));
        if(doc1 == null|| ! doc1.Any())
        {
            return NotFound("No doctor found with the given name.");
        }
        return Ok(doc1);
    }
    [HttpGet("{id}")]
    public IActionResult GetById(string id)
    {
        var doc1 = _unitOfWork.Doctors.GetAll().Where(z=>z.DoctorId == id).Select(x => new DoctorDto
        {
            DoctorName = x.DoctorName,
            SpecializationID = x.SpecializationID,
            ImgUrl = x.ImgUrl,
            Price = x.Price,
            Bio = x.Bio,
            Email = x.Email,
            AvailableDays = x.AvailableDays,
            Rating = x.Rating,
            Address = x.Adress,
               IsActive = x.IsActive,
            PhoneNumber = x.PhoneNumber,

        }).FirstOrDefault();

        if (doc1 == null)
        {
            return NotFound("No doctor found with the given name.");
        }
        return Ok(doc1);    
    }
    [HttpPost]
    public IActionResult Create([FromBody] DoctorDto x)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var newdoc = new Doctor()
        {
            DoctorName = x.DoctorName,
            SpecializationID = x.SpecializationID,
            ImgUrl = x.ImgUrl,
            Price = (int)x.Price,
            Bio = x.Bio,
            Email = x.Email,
            AvailableDays = x.AvailableDays,
            Rating = x.Rating,
            Adress = x.Address,
               IsActive = x.IsActive,
            PhoneNumber = x.PhoneNumber,
        };
        _unitOfWork.Doctors.Add(newdoc);
        _unitOfWork.Save();
        return Ok("Done");
    }
    [HttpPut]
    public IActionResult update(string id,[FromBody] DoctorDto x)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var newdoc = _unitOfWork.Doctors.GetAll().FirstOrDefault(p=>p.DoctorId==id);
        if(newdoc==null)
        {
            return BadRequest(ModelState);
        }
        newdoc.DoctorName= x.DoctorName;
        newdoc.SpecializationID = x.SpecializationID;
        newdoc.Rating = x.Rating;
        newdoc.PhoneNumber  = x.PhoneNumber;
        newdoc.Bio = x.Bio;
        newdoc.Email = x.Email;
        newdoc.Adress = x.Address;
        newdoc.IsActive = x.IsActive;   
        newdoc.AvailableDays= x.AvailableDays;
        _unitOfWork.Doctors.Update(newdoc);
        _unitOfWork.Save();
        return
            Ok("Done");
    }
    [HttpDelete("by{id}")]
    public IActionResult Remove(string id)
    {
        var pp=_unitOfWork.Doctors.GetAll().FirstOrDefault(x=>x.DoctorId== id);
        if(pp==null)
        {
            return BadRequest(ModelState);
        }
        _unitOfWork.Doctors.Delete(pp);
        _unitOfWork.Save();
        return Ok("Done");
    }

}
