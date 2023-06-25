using LabDay2.APIS.Models;
using Microsoft.EntityFrameworkCore;

namespace Day2.DAL
{
    public class DateBase : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Employee> Employee { get; set; }

        public DateBase(DbContextOptions<DateBase> options):base(options)
        {

        }
    }

}
