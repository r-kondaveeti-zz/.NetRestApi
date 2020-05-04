using backend.Repository;
using backend.Models;
using backend.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace backend.RImplementation {

    public class CustomerRepository : ICustomerRepository {

        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context) {
            _context = context;
        }
     
        public void Add(Employee employee) {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public IEnumerable<Employee> GetAll() {
            return _context.Employees.ToList();
        }

        public void Update(Employee preEmployee, Employee curEmployee) {
            preEmployee.Name = curEmployee.Name;
            _context.SaveChanges();
        }

        public string Delete(long id) {
            Employee employee = _context.Employees.Find(id);
            // if(employee.Name == null) {
            //     return "Select a valid customer to delete!";
            // }
            if(employee != null) {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            return "Customer Deleted!";
        }

    }
}