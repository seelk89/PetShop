using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.DomainService
{
    public interface IOwnerRepository
    {
        IEnumerable<Owner> ReadOwners();

        Owner OwnerFoundById(int selectedId);

        void CreateOwner(Owner owner);

        void UpdateOwner(int id, Owner newOwnerData);

        void DeleteOwner(int selectedId);
    }
}
