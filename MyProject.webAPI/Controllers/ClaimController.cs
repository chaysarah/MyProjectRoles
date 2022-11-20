using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyProject.Mock;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.webAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaim _roleRepository;
        public ClaimController()
        {
            var mockContext = new MockContext();
            _roleRepository = new ClaimRepository(mockContext);
        }
        [HttpGet]
        public List<Claim> Get()
        {
            return _roleRepository.GetAll();
        }

        [HttpGet("{id}")]
        public Claim GetById(int id)
        {
            return _roleRepository.GetById(id);
        }

        [HttpPost]//add
        public void Post(int id, Claim r)
        {

        }
        [HttpPut]//update
        public void Put(int id, Claim r)
        {

        }
        [HttpDelete]
        public void delete(int id)
        {
            _roleRepository.Delete(id);
        }
    }
}
