using System.Data.Common;
using System.Data.Entity;
using SimplePeopleInfoManagement.Entity;

namespace SimplePeopleInfoManagement.DbContext
{
    public class PeopleInfoDbContext: System.Data.Entity.DbContext
    {
        public PeopleInfoDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            Configure();
        }

        public PeopleInfoDbContext(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
            Configure();
        }

        private void Configure()
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ModelConfiguration.Configure(modelBuilder);
            var initializer = new PeopleInfoDbInitializer(modelBuilder);
            Database.SetInitializer(initializer);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}