using LabDay2.APIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Bl
{
    public class GetDepartmentWithEmployeesDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public int Evaluation { get; set; }

        public List<EmployeeDTO> Employee { get; set; }
    }
}
