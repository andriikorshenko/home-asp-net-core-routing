using System.Text.Json;

namespace Task_001
{
    public class Warehouse
    {
        public string? ProductName { get; set; }
        public int Quontity { get; set; }
        public uint Price { get; set; }
        public string? Category { get; set; }

        public void SerializeAsJson(string fileName)
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true
            };

            List<Warehouse> inventory = new()
            {
                new Warehouse { ProductName = "Dell 3321F", Quontity = 12, Price = 32_000, Category = "PC" },
                new Warehouse { ProductName = "Apple MacBook Pro", Quontity = 12, Price = 51_000, Category = "PC" },
                new Warehouse { ProductName = "Razor Mouse 12A", Quontity = 12, Price = 1000, Category = "Office" },
                new Warehouse { ProductName = "ASUS Keys 88", Quontity = 12, Price = 425, Category = "Office" },
                new Warehouse { ProductName = "Apple Pen", Quontity = 12, Price = 225, Category = "Office" }
            };

            File.WriteAllText(fileName, JsonSerializer.Serialize(inventory, options));
        }

        public T? ReadAsJsonFormat<T>(string fileName)
        {
            return JsonSerializer.Deserialize<T>(File.ReadAllText(fileName));
        }
    }
}
