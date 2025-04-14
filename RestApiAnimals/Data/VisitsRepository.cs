using RestApiAnimals.Models;

namespace RestApiAnimals.Data;

public class VisitsRepository
{
    public static List<Visit> Visits =
    [
        new()
        {
            Id = 1, Date = new DateTime(2024, 3, 12), AnimalId = 1, Description = "Routine checkup", Price = 50.00
        },
        new() { Id = 2, Date = new DateTime(2024, 4, 2), AnimalId = 2, Description = "Vaccination", Price = 75.00 },
        new()
        {
            Id = 3, Date = new DateTime(2024, 2, 20), AnimalId = 3, Description = "Surgery follow-up", Price = 120.00
        },
        new() { Id = 4, Date = new DateTime(2024, 5, 1), AnimalId = 4, Description = "Dental cleaning", Price = 90.00 },
        new()
        {
            Id = 5, Date = new DateTime(2024, 3, 27), AnimalId = 5, Description = "Limp examination", Price = 60.00
        },
        new()
        {
            Id = 6, Date = new DateTime(2024, 4, 15), AnimalId = 6, Description = "Allergy treatment", Price = 85.00
        },
        new() { Id = 7, Date = new DateTime(2024, 2, 10), AnimalId = 7, Description = "Wound cleaning", Price = 55.00 },
        new()
        {
            Id = 8, Date = new DateTime(2024, 3, 18), AnimalId = 8, Description = "Skin infection check", Price = 65.00
        },
        new() { Id = 9, Date = new DateTime(2024, 1, 29), AnimalId = 9, Description = "Ear infection", Price = 70.00 },
        new()
        {
            Id = 10, Date = new DateTime(2024, 4, 5), AnimalId = 10, Description = "X-ray after injury", Price = 110.00
        },
        new()
        {
            Id = 11, Date = new DateTime(2024, 3, 8), AnimalId = 11, Description = "Vaccination booster", Price = 80.00
        },
        new()
        {
            Id = 12, Date = new DateTime(2024, 2, 16), AnimalId = 12, Description = "Parasite treatment", Price = 95.00
        },
        new() { Id = 13, Date = new DateTime(2024, 1, 11), AnimalId = 13, Description = "Eye exam", Price = 45.00 },
        new()
        {
            Id = 14, Date = new DateTime(2024, 5, 3), AnimalId = 14, Description = "Stomach issue", Price = 100.00
        },
        new()
        {
            Id = 15, Date = new DateTime(2024, 3, 21), AnimalId = 15, Description = "Surgery consultation",
            Price = 130.00
        },
        new()
        {
            Id = 16, Date = new DateTime(2024, 4, 9), AnimalId = 16, Description = "Neutering checkup", Price = 105.00
        },
        new()
        {
            Id = 17, Date = new DateTime(2024, 2, 25), AnimalId = 17, Description = "Behavioral consultation",
            Price = 90.00
        },
        new()
        {
            Id = 18, Date = new DateTime(2024, 3, 4), AnimalId = 18, Description = "Fur condition inspection",
            Price = 55.00
        },
        new()
        {
            Id = 19, Date = new DateTime(2024, 4, 18), AnimalId = 19, Description = "Limping diagnosis", Price = 75.00
        },
        new()
        {
            Id = 20, Date = new DateTime(2024, 5, 7), AnimalId = 20, Description = "General wellness exam",
            Price = 60.00
        },
    ];
}