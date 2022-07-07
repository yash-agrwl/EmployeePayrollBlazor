using CommonLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IEmployeeManager
    {
        EmployeeModel AddEmployee(EmployeeModel employee);
        int DeleteEmployee(int empId);
        List<EmployeeModel> GetAllEmployee();
        EmployeeModel GetEmployeeById(int empId);
        EmployeeModel UpdateEmployee(EmployeeModel employee);
    }
}