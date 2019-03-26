using System.Collections.Generic;

namespace DesignAlternatives.WinApp.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<SubCategory> SubCategories { get; set; }

        public Category()
        {
            SubCategories = new List<SubCategory>();
        }
    }
}
