using System.Data.Entity;

namespace ContinousDeploymentWithEF.Database
{
    public class Db: DbContext
    {
        public DbSet<Person> People { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}