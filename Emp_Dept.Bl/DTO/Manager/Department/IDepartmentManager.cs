using Day2.Bl.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Bl.DTO.Manager
{
    public interface IDepartmentManager
    {
        List<DepartmentReadDTO> GetAll();
        DepartmentReadDTO ? GetById(int id);
        int Add(DepartmentAddDTO deapartment);
        bool Update(DepartmentUpdateDTO deapartment);
        bool Delete(int id);
        GetDepartmentWithEmployeesDTO GetDepartmentByIdWithEmployees(int id);


    }
}
