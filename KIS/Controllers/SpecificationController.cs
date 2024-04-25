using KIS.Interfaces;
using KIS.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class SpecificationController : ControllerBase
{
    private readonly ISpecificationRepository _SpecificationRepository;

    public SpecificationController(ISpecificationRepository SpecificationRepository)
    {
        _SpecificationRepository = SpecificationRepository;
    }

    [HttpGet]
    public IActionResult GetAllSpecifications()
    {
        var Specifications = _SpecificationRepository.GetAll();
        return Ok(Specifications);
    }

    [HttpGet("{positionId}")]
    public IActionResult GetSpecification(int positionId)
    {
        var Specification = _SpecificationRepository.GetById(positionId);
        if (Specification == null)
        {
            return NotFound();
        }
        return Ok(Specification);
    }


    [HttpPost]
    public IActionResult CreateSpecification(SpecificationModel Specification)
    {
        _SpecificationRepository.Add(Specification);
        return CreatedAtAction("GetSpecification", new { id = Specification.PositionID }, Specification);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateSpecification(int positionID, SpecificationModel Specification)
    {
        if (positionID != Specification.PositionID)
        {
            return BadRequest();
        }

        _SpecificationRepository.Update(Specification);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteSpecification(int positionID)
    {
        _SpecificationRepository.Delete(positionID);

        return NoContent();
    }

}
