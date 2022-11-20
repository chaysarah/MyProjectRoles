using AutoMapper;
using MyProject.Common;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using policy = MyProject.Common.policy;

namespace MyProject.Services.Services
{

    public class ClaimService : IClaimServise
    {
        private readonly IClaim _claimRepository;
        private readonly IMapper _mapper;
        public ClaimService(IClaim claimRepository,IMapper mapper)
        {
            _claimRepository = claimRepository;
            _mapper = mapper;
        }
        public List<ClaimDTO> GetAll()
        {
            //...לוגיקה
            var claim=_claimRepository.GetAll();
            return _mapper.Map<List<ClaimDTO>>(claim);

        }
        public ClaimDTO GetById(int id)
        {
            //...לוגיקה
            var claim=_claimRepository.GetById(id);
            return _mapper.Map<ClaimDTO>(claim);
        }
        public ClaimDTO Add(int id, int idRole, int idPermission, policy p)
        {
            //...לוגיקה
            var claim = _claimRepository.Add(id,idRole,idPermission, (Repositories.Entities.policy)p);
            return _mapper.Map<ClaimDTO>(claim);

        }
        public ClaimDTO Update(ClaimDTO clai)
        {
            //...לוגיקה
            Claim claim = _mapper.Map<Claim>(clai);
            return _mapper.Map<ClaimDTO>(_claimRepository.Update(claim));
        }
        public void Delete(int id)
        {
            //...לוגיקה
            _claimRepository.Delete(id);

        }
    }
}
