using Microsoft.EntityFrameworkCore;

namespace Day2.DAL.Repo
{
    public class DepartmentRepo : IDepartmentRepo
    {

        private readonly DateBase context;

        public DepartmentRepo(DateBase Context)
        {
            context = Context;
        }

        public void Add(Department department)
        {
            context.Add(department);
        }

        public void Delete(Department department)
        {
            context.Remove(department);
        }

        public IEnumerable<Department> GetAll()
        {
            return context.Department.ToList();
        }

        public Department? GetById(int id)
        {
            return context.Set<Department>().Find(id);
        }
        public void Update(Department department)
        {
            context.Set<Department>().Update(department);
        }

        public int SaveChange()
        {
            return context.SaveChanges();
        }

        public Department GetDepartmentByIdWithEmployees(int id)
        {
            var department = context.Department.Include(p => p.Employee).FirstOrDefault(p => p.Id == id);
            if (department == null)
                return null;
            return department;
        }

    }
}
