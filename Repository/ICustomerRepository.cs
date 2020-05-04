using backend.Models;
using System.Collections.Generic;

namespace backend.Repository {

    public interface ICustomerRepository {

        //ADD
        void Add(Employee employee);

        //Update
        void Update(Employee preEmployee, Employee curEmployee);

        //Delete
        string Delete(long id);

        //Get All
        IEnumerable<Employee> GetAll();

    }
}