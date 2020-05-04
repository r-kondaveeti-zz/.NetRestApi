using Microsoft.AspNetCore.Mvc;
using backend.Repository;
using backend.Models;
using System.Collections.Generic;

namespace backend.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class TrialController : ControllerBase {

        private readonly ICustomerRepository _repository;

        public TrialController(ICustomerRepository repository) {
            _repository = repository;
        }

        [HttpGet]
        public string run() {
            return "Welcome to Customer List";
        }

        [HttpGet("{name}", Name = "Get")]
        public IActionResult saveEmployee(string name) {
            Employee employee = new Employee();
            employee.Name = name;
            _repository.Add(employee);
            return Ok(employee);
        }

        [HttpGet]
        [Route("listall")]
        public IActionResult getAllEmployees() {
           return Ok(_repository.GetAll());
        }

        [HttpGet]
        [Route("delete/{id}")]
        public string removeEmployee(long id) {
            
            return _repository.Delete(id);
        }
        
    }
}