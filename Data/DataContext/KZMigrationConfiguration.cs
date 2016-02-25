using System.Data.Entity.Migrations;

namespace DataContext
{
    public class KZMigrationConfiguration:DbMigrationsConfiguration<DatabaseContext>
    {
        public KZMigrationConfiguration()
        {
            AutomaticMigrationsEnabled = true;
           

        }

        protected override void Seed(DatabaseContext context)
        {
            base.Seed(context);
        }
    }
}