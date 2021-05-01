using EmpManagment.Model;

namespace EmpManagment.Model
{
    public interface IEmployeeRepository
    {
        public Employee GetEmpolyee(int Id);
    }
}