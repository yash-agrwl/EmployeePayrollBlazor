using System;
using System.Collections.Generic;
using System.Data;
using CommonLayer;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace RepositoryLayer
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;

        public EmployeeRepository(IConfiguration config)
        {
            _config = config;
            _connectionString = _config.GetConnectionString("EmployeeDB");
        }

        public EmployeeModel AddEmployee(EmployeeModel employee)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(_connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_AddEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@ProfileImage", employee.ProfileImage);
                    cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@Department", employee.Department);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@StartDate", employee.StartDate);
                    cmd.Parameters.AddWithValue("@Notes", employee.Notes);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return employee;
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
                List<EmployeeModel> list = new List<EmployeeModel>();
                using (MySqlConnection con = new MySqlConnection(_connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand("sp_GetAllEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        EmployeeModel employee = new EmployeeModel();

                        employee.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"]);
                        employee.Name = dataReader["Name"].ToString();
                        employee.ProfileImage = dataReader["ProfileImage"].ToString();
                        employee.Gender = dataReader["Gender"].ToString();
                        employee.Department = dataReader["Department"].ToString();
                        employee.Salary = Convert.ToInt32(dataReader["Salary"]);
                        employee.StartDate = Convert.ToDateTime(dataReader["StartDate"]);
                        employee.Notes = dataReader["Notes"].ToString();

                        list.Add(employee);
                    }

                    con.Close();
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EmployeeModel GetEmployeeById(int empId)
        {
            EmployeeModel employee = new EmployeeModel();
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("sp_GetEmployeeById", con);
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    employee.EmployeeID = Convert.ToInt32(dataReader["EmployeeID"]);
                    employee.Name = dataReader["Name"].ToString();
                    employee.ProfileImage = dataReader["ProfileImage"].ToString();
                    employee.Gender = dataReader["Gender"].ToString();
                    employee.Department = dataReader["Department"].ToString();
                    employee.Salary = Convert.ToInt32(dataReader["Salary"]);
                    employee.StartDate = Convert.ToDateTime(dataReader["StartDate"]);
                    employee.Notes = dataReader["Notes"].ToString();
                }

                con.Close();
            }
            return employee;
        }

        public EmployeeModel UpdateEmployee(EmployeeModel employee)
        {
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("sp_UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@empId", employee.EmployeeID);
                cmd.Parameters.AddWithValue("@name", employee.Name);
                cmd.Parameters.AddWithValue("@img", employee.ProfileImage);
                cmd.Parameters.AddWithValue("@gender", employee.Gender);
                cmd.Parameters.AddWithValue("@department", employee.Department);
                cmd.Parameters.AddWithValue("@salary", employee.Salary);
                cmd.Parameters.AddWithValue("@startDate", employee.StartDate);
                cmd.Parameters.AddWithValue("@notes", employee.Notes);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return employee;
        }

        public int DeleteEmployee(int empId)
        {
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("sp_DeleteEmployee", con);
                cmd.Parameters.AddWithValue("@empId", empId);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return empId;
        }
    }
}
