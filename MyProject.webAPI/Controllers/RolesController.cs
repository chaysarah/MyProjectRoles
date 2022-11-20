using Microsoft.AspNetCore.Mvc;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System.Collections.Generic;

namespace MyProject.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRole _roleRepository;
        public RolesController(IRole roleRepository)
        {
            //var mockContext = new MockContext();
            _roleRepository = roleRepository;//new RoleRepository(mockContext);
        }
        [HttpGet]
        public List<Role> Get()
        {
            return _roleRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Role GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        [HttpPost]//add
        public void Post(int id, Role r)
        {

        }
        [HttpPut]//update
        public void Put(int id, Role r)
        {

        }
        [HttpDelete]
        public void delete(int id)
        {
            _roleRepository.Delete(id);
        }
    }
}
