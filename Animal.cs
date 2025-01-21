public class Animal
{
    private static int _globalId = 1;
    public int Id { get; private set; } 
    public string Name { get; set; }
    public string Species { get; set; }
    public int Age { get; set; }
    public bool CanFly { get; set; }
    public bool IsVenomous { get; set; }
    public int Quantity { get; set; }

    
    public Animal(string name, string species, int age, bool canFly, bool isVenomous, int quantity)
    {
        Id = _globalId++; 
        Name = name;
        Species = species;
        Age = age;
        CanFly = canFly;
        IsVenomous = isVenomous;
        Quantity = quantity;
    }

    
    public override string ToString()
    {
        return $"ID: {Id}, Name: {Name}, Species: {Species}, Age: {Age}, Can Fly: {CanFly}, Is Venomous: {IsVenomous}, Quantity: {Quantity}";
    }
}