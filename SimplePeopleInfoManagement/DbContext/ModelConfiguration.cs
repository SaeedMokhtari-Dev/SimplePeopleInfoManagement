using System.Data.Entity;
using SimplePeopleInfoManagement.Entity;
using SimplePeopleInfoManagement.Models;

namespace SimplePeopleInfoManagement.DbContext
{
    public static class ModelConfiguration
    {
        public static void Configure(DbModelBuilder modelBuilder)
        {
            ConfigurePersonEntity(modelBuilder);
            ConfigureCategoryEntity(modelBuilder);
        }

        private static void ConfigurePersonEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasOptional(w => w.Category)
                .WithMany(w => w.People)
                .WillCascadeOnDelete(false);
        }
        private static void ConfigureCategoryEntity(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>();
        }
    }
}