using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.ApplicationService
{
    public interface IOwnerService
    {
        List<Owner> GetOwners();

        Owner OwnerFoundById(int selectedId);

        void CreateOwner(Owner owner);

        void UpdateOwner(int id, Owner owner);

        void DeleteOwner(int id);
    }
}
