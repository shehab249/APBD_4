using Microsoft.AspNetCore.Mvc;
using RestApiAnimals.Contracts.Requests;
using RestApiAnimals.Data;
using RestApiAnimals.Models;

namespace RestApiAnimals.Controllers;

[ApiController]
[Route("api/animals")]
public class AnimalsController : ControllerBase
{
    private readonly List<Animal> _animals = AnimalsRepository.Animals;
    private readonly List<Visit> _visits = VisitsRepository.Visits;


    #region CRUD
    
    // Get all animals
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_animals);
    }
    
    // Get specific animal by id
    [HttpGet("{id:int}")]
    public IActionResult Get(int id)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == id);
        if(animal is null) return NotFound();
        return Ok(animal);
    }
    
    // Create a new animal
    [HttpPost]
    public IActionResult Create(CreateAnimalRequest animalToCreate)
    {
        var id = _animals.Max(a => a.Id) + 1;
        var animal = new Animal { Id = id, Name = animalToCreate.Name, Category = animalToCreate.Category, Weight = animalToCreate.Weight, FurColor = animalToCreate.FurColor };
        _animals.Add(animal);
        return CreatedAtAction(nameof(Get), new { id }, animal);
    }
    
    //update exisitng animal
    [HttpPut("{id}")]
    public IActionResult Update([FromRoute] int id, [FromBody] UpdateAnimalRequest animalToUpdate)
    {
        var animal = _animals.FirstOrDefault(u => u.Id == id);
        if (animal is null) return NotFound();
        animal.Name = animalToUpdate.Name;
        animal.Category = animalToUpdate.Category;
        animal.Weight = animalToUpdate.Weight;
        animal.FurColor = animalToUpdate.FurColor;
        return Ok(animal);
    }
    
    // Delete provided animal
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == id);
        if (animal is null) return NotFound();
        _animals.Remove(animal);
        return NoContent();
    }
    
    #endregion
    
    #region CRUD - Subresource
    
    // Get all visits for specific animal
    [HttpGet("{AnimalId:}/Visits")]
    public IActionResult GetAllAnimalVisits(int AnimalId)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == AnimalId);
        if (animal is null) return NotFound();
        var visits = _visits.Where(v => v.AnimalId == AnimalId);
        return Ok(visits.ToList());
    }
        
    
    // Get specific order for the provided animal
    [HttpGet("{AnimalId:}/Visits/{VisitId:int}")]
    public IActionResult GetAllAnimalVisits(int AnimalId, int visitId)
    {
        var animal = _animals.FirstOrDefault(a => a.Id == AnimalId);
        if (animal is null) return NotFound();
        var visits = _visits
            .Where(v => v.AnimalId == animal.Id)
            .Where(v => v.AnimalId == visitId);
        return Ok(visits.ToList());
    }
    
    #endregion
}