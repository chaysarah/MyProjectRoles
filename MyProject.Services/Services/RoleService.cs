using AutoMapper;
using MyProject.Common;
using MyProject.Repositories.Interfaces;
using MyProject.Repositories.Entities;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
    public class RoleService : IRoleService
    {
        private readonly IMapper _mapper;
        private readonly IRole _roleRepository;
        public RoleService(IRole roleRepository,IMapper mapper)
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
        }
        public List<RoleDTO> GetAll()
        {
            //...לוגיקה
            var Role = _roleRepository.GetAll();
            return _mapper.Map<List<RoleDTO>>(Role);
        }
        public RoleDTO GetById(int id)
        {
            //...לוגיקה
            var Role = _roleRepository.GetById(id);
            return _mapper.Map<RoleDTO>(Role);

        }
        public RoleDTO Add(int id, string name)
        {
            //...לוגיקה
            var Role = _roleRepository.Add(id,name);
            return _mapper.Map<RoleDTO>(Role);

        }
        public RoleDTO Update(RoleDTO Role)
        {
            //...לוגיקה
            Role Rol = _mapper.Map<Role>(Role);
            return _mapper.Map<RoleDTO>(_roleRepository.Update(Rol));
        }
        public void Delete(int id)
        {
            //...לוגיקה
            _roleRepository.Delete(id);

        }
    }
}
