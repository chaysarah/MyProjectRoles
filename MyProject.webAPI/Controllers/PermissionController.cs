using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System.Collections.Generic;

namespace MyProject.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        private readonly IPermission _roleRepository;
        public PermissionController()
        {
            var mockContext = new MockContext();
            _roleRepository = new PermissionRepository(mockContext);
        }
        [HttpGet]
        public List<Permission> Get()
        {
            return _roleRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Permission GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        [HttpPost]//add
        public void Post(int id, Permission r)
        {

        }
        [HttpPut]//update
        public void Put(int id, Permission r)
        {

        }
        [HttpDelete]
        public void delete(int id)
        {
            _roleRepository.Delete(id);
        }
    }
}
