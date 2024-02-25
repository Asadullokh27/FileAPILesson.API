using Microsoft.EntityFrameworkCore;

namespace FileAPILesson.Infrastructure.Persistance
{
    public class ApplicationDBContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
       : base(options)
        {

        }
        public Microsoft.EntityFrameworkCore.DbSet<Person> Persons { get; set; }

    }
}
