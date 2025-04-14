using RestApiAnimals.Models;

namespace RestApiAnimals.Data;

public class AnimalsRepository
{
    public static readonly List<Animal> Animals =
    [
        new() { Id = 1, Name = "Dog", Category = "Mammal", Weight = 20.5, FurColor = "Brown" },
    new() { Id = 2, Name = "Cat", Category = "Mammal", Weight = 4.2, FurColor = "Gray" },
    new() { Id = 3, Name = "Elephant", Category = "Mammal", Weight = 5400, FurColor = "None" },
    new() { Id = 4, Name = "Tiger", Category = "Mammal", Weight = 220.5, FurColor = "Orange with black stripes" },
    new() { Id = 5, Name = "Lion", Category = "Mammal", Weight = 190.0, FurColor = "Golden" },
    new() { Id = 6, Name = "Bear", Category = "Mammal", Weight = 300.0, FurColor = "Black" },
    new() { Id = 7, Name = "Wolf", Category = "Mammal", Weight = 45.0, FurColor = "Gray" },
    new() { Id = 8, Name = "Fox", Category = "Mammal", Weight = 6.5, FurColor = "Red" },
    new() { Id = 9, Name = "Zebra", Category = "Mammal", Weight = 350.0, FurColor = "Black and white" },
    new() { Id = 10, Name = "Giraffe", Category = "Mammal", Weight = 800.0, FurColor = "Yellow with brown spots" },
    new() { Id = 11, Name = "Kangaroo", Category = "Mammal", Weight = 85.0, FurColor = "Light brown" },
    new() { Id = 12, Name = "Panda", Category = "Mammal", Weight = 100.0, FurColor = "Black and white" },
    new() { Id = 13, Name = "Leopard", Category = "Mammal", Weight = 90.0, FurColor = "Yellow with black spots" },
    new() { Id = 14, Name = "Cheetah", Category = "Mammal", Weight = 72.0, FurColor = "Yellow with black spots" },
    new() { Id = 15, Name = "Rabbit", Category = "Mammal", Weight = 2.5, FurColor = "White" },
    new() { Id = 16, Name = "Deer", Category = "Mammal", Weight = 70.0, FurColor = "Brown" },
    new() { Id = 17, Name = "Horse", Category = "Mammal", Weight = 500.0, FurColor = "Black" },
    new() { Id = 18, Name = "Cow", Category = "Mammal", Weight = 600.0, FurColor = "White with black spots" },
    new() { Id = 19, Name = "Goat", Category = "Mammal", Weight = 55.0, FurColor = "White" },
    new() { Id = 20, Name = "Sheep", Category = "Mammal", Weight = 70.0, FurColor = "White" }
        

    ];
}