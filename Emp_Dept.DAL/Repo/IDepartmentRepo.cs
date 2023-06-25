using LabDay2.APIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Repo
{
    public interface IDepartmentRepo
    {
        void Add(Department department);
        IEnumerable<Department> GetAll();
        void Update(Department department);

        Department GetById(int id);
        void Delete(Department department);
        int SaveChange();
        Department GetDepartmentByIdWithEmployees(int id); 
    }
}
