using AutoMapper;
using MyProject.Common;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Services.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IMapper _mapper;
        private readonly IPermission _PermissionRepository;
        public PermissionService(IPermission PermissionRepository,IMapper mapper)
        {
            _PermissionRepository = PermissionRepository;
            _mapper = mapper;
        }

        public List<PermissionDTO> GetAll()
        {
            //...לוגיקה
            var Permission= _PermissionRepository.GetAll();
            return _mapper.Map<List<PermissionDTO>>(Permission);
        }
        public PermissionDTO GetById(int id)
        {
            //...לוגיקה
            var Permission = _PermissionRepository.GetById(id);
            return _mapper.Map<PermissionDTO>(Permission);

        }
        public PermissionDTO Add(int id, string name)
        {
            //...לוגיקה
            var Permission = _PermissionRepository.Add(id,name);
            return _mapper.Map<PermissionDTO>(Permission);

        }
        public PermissionDTO Update(PermissionDTO Permissio)
        {
            //...לוגיקה
            Permission Permiss = _mapper.Map<Permission>(Permissio);
            return _mapper.Map<PermissionDTO>(_PermissionRepository.Update(Permiss));

        }
        public void Delete(int id)
        {
            //...לוגיקה
            _PermissionRepository.Delete(id);

        }
    }
}
