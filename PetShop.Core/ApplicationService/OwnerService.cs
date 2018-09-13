using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.Core.ApplicationService
{
    public class OwnerService : IOwnerService
    {
        private readonly IOwnerRepository _ownerRepository;

        public OwnerService(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        public List<Owner> GetOwners()
        {
            return _ownerRepository.ReadOwners().ToList();
        }

        public Owner OwnerFoundById(int selectedId)
        {
            return _ownerRepository.OwnerFoundById(selectedId);
        }

        public void CreateOwner(Owner owner)
        {
            _ownerRepository.CreateOwner(owner);
        }

        public void UpdateOwner(int id, Owner owner)
        {
            _ownerRepository.UpdateOwner(id, owner);
        }

        public void DeleteOwner(int id)
        {
            _ownerRepository.DeleteOwner(id);
        }
    }
}
