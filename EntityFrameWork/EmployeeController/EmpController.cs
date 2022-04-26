using EntityFrameWork.DataAccess;
using EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameWork.EmployeeController
{
    public class EmpController
    {
        private readonly AppDbContext _db;
        public EmpController()
        {
            _db = new AppDbContext();
        }

        public void GetEmployeeById(int id)
        {
            
            try
            {
                Employee employee = _db.Employees.Find(id);
                Console.WriteLine(employee);

            }
            catch (Exception)
            {

                Console.WriteLine("Not found");
            }
            
        }

        public void GetAll()
        {
            List<Employee> employee =_db.Employees.ToList();
            foreach (var item in employee)
            {
                Console.WriteLine(item.FullName);
            }
        }

        public void AddEmployee(string fullname)
        {
            try
            {
                Employee employee = new Employee { FullName = fullname };
                _db.Employees.Add(employee);
                _db.SaveChanges();
                Console.WriteLine("Employee added");
            }
            catch (Exception)
            {

                Console.WriteLine("Some problem exists.");
            }
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                Employee employee = _db.Employees.Find(id);
                _db.Employees.Remove(employee);
                _db.SaveChanges();
                Console.WriteLine("Suceed");

            }
            catch (Exception)
            {

                Console.WriteLine("Not found");

            }
        }
        public void FilterByName(string letter)
        {
            try
            {
                List<Employee> employee = _db.Employees.ToList();
                foreach (var item in employee)
                {
                    if (item.FullName.Contains(letter))
                    {
                        Console.WriteLine(item.FullName);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Some problem exists.");
            }
            
        }
    }
}
