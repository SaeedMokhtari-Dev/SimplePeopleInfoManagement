using System.Data.Entity;
using SimplePeopleInfoManagement.Entity;
using SQLite.CodeFirst;

namespace SimplePeopleInfoManagement.DbContext
{
    public class PeopleInfoDbInitializer: SqliteDropCreateDatabaseWhenModelChanges<PeopleInfoDbContext>
    {
        public PeopleInfoDbInitializer(DbModelBuilder modelBuilder)
            : base(modelBuilder, typeof(CustomHistory))
        { }

        protected override void Seed(PeopleInfoDbContext context)
        {
            // Here you can seed your core data if you have any.
        }
    }
}