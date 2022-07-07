using CommonLayer;
using RepositoryLayer;
using System;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class EmployeeManger : IEmployeeManager
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeManger(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            try
            {
                return this.employeeRepository.AddEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<EmployeeModel> GetAllEmployee()
        {
            try
            {
                return this.employeeRepository.GetAllEmployee();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EmployeeModel GetEmployeeById(int empId)
        {
            try
            {
                return this.employeeRepository.GetEmployeeById(empId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employee)
        {
            try
            {
                return this.employeeRepository.UpdateEmployee(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int DeleteEmployee(int empId)
        {
            try
            {
                return this.employeeRepository.DeleteEmployee(empId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
