using LabDay2.APIS.Models;

namespace  Day2.DAL
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Budget { get; set; }
        public int Evaluation { get; set; }

        public List<Employee> Employee { get; set; }

    }
}
