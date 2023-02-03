using Microsoft.EntityFrameworkCore;

namespace EfCodeFirstExample.Models
{
    public partial class JuhuKhargharJan23Context : DbContext
    {
        public JuhuKhargharJan23Context()
        {
        }

        public JuhuKhargharJan23Context(DbContextOptions<JuhuKhargharJan23Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
    }
}
