using Day2.Bl.DTO;
using Day2.DAL.Repo;
using Day2.DAL;
using Day2.Bl.DTO.Manager;

namespace Day2.Bl
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartmentRepo _departmentRepo;

        public DepartmentManager(IDepartmentRepo departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }
        public int Add(DepartmentAddDTO departmentRepo)
        {
            Department dept = new Department
            {
                Name = departmentRepo.Name,
                Budget = departmentRepo.Budget,
            };
            _departmentRepo.Add(dept);
            _departmentRepo.SaveChange();
            return dept.Id;
        }

        public bool Delete(int id)
        {
            var deptFromDb = _departmentRepo.GetById(id);
            if (deptFromDb == null)
                return false;
            _departmentRepo.Delete(deptFromDb);
            return true;
        }

        public List<DepartmentReadDTO> GetAll()
        {

            var deptfromDb=_departmentRepo.GetAll();
            return deptfromDb.Select(p => new DepartmentReadDTO
            {
                Id = p.Id,
                Name = p.Name,
                Evaluation = p.Evaluation,
            }).ToList();
        }

        public DepartmentReadDTO? GetById(int id)
        {
            var deptfromDb= _departmentRepo.GetById(id);
            if (deptfromDb == null)
                return null;
            return new DepartmentReadDTO { Id=deptfromDb.Id,Name=deptfromDb.Name,Evaluation=deptfromDb.Evaluation };
        }

        public bool Update(DepartmentUpdateDTO deapartment)
        {
            var deptFromDb = _departmentRepo.GetById(deapartment.Id);
            if(deptFromDb == null)
                return false;
            deptFromDb.Id= deapartment.Id;
            deptFromDb.Name= deapartment.Name;
            deptFromDb.Budget= deapartment.Budget;
            _departmentRepo.Update(deptFromDb);
            _departmentRepo.SaveChange();
            return true;
        }
        public GetDepartmentWithEmployeesDTO? GetDepartmentByIdWithEmployees(int id)
        {
            var deptFromDb=_departmentRepo.GetDepartmentByIdWithEmployees(id);
            if (deptFromDb == null)
                return null;

            return new GetDepartmentWithEmployeesDTO
            { Id = deptFromDb.Id, Name = deptFromDb.Name, Evaluation = deptFromDb.Evaluation ,
                Employee= deptFromDb.Employee.Select(e => 
                        new EmployeeDTO{
                            Id=e.Id,
                            Name=e.Name
                        }).ToList()};
        }


    }
}
