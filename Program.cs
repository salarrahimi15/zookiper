public class ZooManager
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
        Console.WriteLine("Animal added successfully!");
    }


    public void ListAnimals()
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("No animals in the zoo.");
            return;
        }

        Console.WriteLine("Animals in the zoo:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    
    public void ViewAnimalDetails(int id)
    {
        var animal = animals.Find(a => a.Id == id);
        if (animal == null)
        {
            Console.WriteLine("Animal not found.");
            return;
        }

        Console.WriteLine("Animal details:");
        Console.WriteLine(animal);
    }

    
    public void EditAnimal(int id, string name, string species, int age, bool canFly, bool isVenomous, int quantity)
    {
        var animal = animals.Find(a => a.Id == id);
        if (animal == null)
        {
            Console.WriteLine("Animal not found.");
            return;
        }

        animal.Name = name;
        animal.Species = species;
        animal.Age = age;
        animal.CanFly = canFly;
        animal.IsVenomous = isVenomous;
        animal.Quantity = quantity;

        Console.WriteLine("Animal updated successfully!");
    }

    
    public void DeleteAnimal(int id)
    {
        var animal = animals.Find(a => a.Id == id);
        if (animal == null)
        {
            Console.WriteLine("Animal not found.");
            return;
        }

        animals.Remove(animal);
        Console.WriteLine("Animal deleted successfully!");
    }
}


class Program
{
    static void Main(string[] args)
    {
        ZooManager zooManager = new ZooManager();

        while (true)
        {
            Console.WriteLine("\nZoo Management System:");
            Console.WriteLine("1. Add Animal");
            Console.WriteLine("2. List All Animals");
            Console.WriteLine("3. View Animal Details");
            Console.WriteLine("4. Edit Animal");
            Console.WriteLine("5. Delete Animal");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter species: ");
                    string species = Console.ReadLine();

                    Console.Write("Enter age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Can fly (true/false): ");
                    bool canFly = bool.Parse(Console.ReadLine());

                    Console.Write("Is venomous (true/false): ");
                    bool isVenomous = bool.Parse(Console.ReadLine());

                    Console.Write("Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());

                    zooManager.AddAnimal(new Animal(name, species, age, canFly, isVenomous, quantity));
                    break;

                case 2:
                    zooManager.ListAnimals();
                    break;

                case 3:
                    Console.Write("Enter animal ID: ");
                    int viewId = int.Parse(Console.ReadLine());
                    zooManager.ViewAnimalDetails(viewId);
                    break;

                case 4:
                    Console.Write("Enter animal ID: ");
                    int editId = int.Parse(Console.ReadLine());

                    Console.Write("Enter new name: ");
                    name = Console.ReadLine();

                    Console.Write("Enter new species: ");
                    species = Console.ReadLine();

                    Console.Write("Enter new age: ");
                    age = int.Parse(Console.ReadLine());

                    Console.Write("Can fly (true/false): ");
                    canFly = bool.Parse(Console.ReadLine());

                    Console.Write("Is venomous (true/false): ");
                    isVenomous = bool.Parse(Console.ReadLine());

                    Console.Write("Enter new quantity: ");
                    quantity = int.Parse(Console.ReadLine());

                    zooManager.EditAnimal(editId, name, species, age, canFly, isVenomous, quantity);
                    break;

                case 5:
                    Console.Write("Enter animal ID: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    zooManager.DeleteAnimal(deleteId);
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
