using DesignAlternatives.WinApp.Models;
using System.Data.Entity;

namespace DesignAlternatives.WinApp.DataAccess
{
    public class DesignAlternativesDb : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<DesignOption> DesignOptions { get; set; }

        public DbSet<DesignAlternative> DesignAlternatives { get; set; }
    }
}
