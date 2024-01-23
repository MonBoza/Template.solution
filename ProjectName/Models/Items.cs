using System.Collections.Generic;
// Change the namespace to match the name of your project
namespace ProjectName.Models
{
    public class Item
    {
        public string Description { get; set; }
        public int Id { get; }
        private static List<Item> _instances = new List<Item> { };

        public Item(string description)
        {
            Description = description;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Item> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Item Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}

// Compare this snippet from ProjectName/Views/Home/Index.cshtml:
// change the namespace to match the name of your project
// change Models to match the name of your Models according to the project