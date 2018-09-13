using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.Infrastructure
{
    public class OwnerRepository : IOwnerRepository
    {
        int ownerId = 4;

        public IEnumerable<Owner> ReadOwners()
        {
            return FakeDB.owners;
        }

        public Owner OwnerFoundById(int selectedId)
        {
            var owner = FakeDB.owners.ToList().Single(item => item.id == selectedId);
            return owner;
        }

        public void CreateOwner(Owner owner)
        {
            owner.id = ownerId;
            ownerId++;

            var _owners = FakeDB.owners.ToList();
            _owners.Add(owner);
            FakeDB.owners = _owners;
        }

        public void UpdateOwner(int id, Owner newOwnerData)
        {
            var ownerToUpdate = this.OwnerFoundById(id);

            ownerToUpdate.firstName = newOwnerData.firstName;
            ownerToUpdate.lastName = newOwnerData.lastName;
            ownerToUpdate.address = newOwnerData.address;
            ownerToUpdate.phoneNumber = newOwnerData.phoneNumber;
            ownerToUpdate.email = newOwnerData.email;
        }

        public void DeleteOwner(int selectedId)
        {
            var _owners = FakeDB.owners.ToList();
            var owner = _owners.Single(item => item.id == selectedId);
            _owners.Remove(owner);
            FakeDB.owners = _owners;
        }
    }
}
