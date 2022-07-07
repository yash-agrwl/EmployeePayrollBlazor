using CommonLayer;
using System.Collections.Generic;

namespace RepositoryLayer
{
    public interface IEmployeeRepository
    {
        EmployeeModel AddEmployee(EmployeeModel employee);
        int DeleteEmployee(int empId);
        List<EmployeeModel> GetAllEmployee();
        EmployeeModel GetEmployeeById(int empId);
        EmployeeModel UpdateEmployee(EmployeeModel employee);
    }
}