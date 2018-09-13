using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructure.SQLRepositories
{
    class OwnerRepository : IOwnerRepository
    {
        readonly PetShopContext _ctx;

        public OwnerRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }

        public void CreateOwner(Owner owner)
        {
            _ctx.Add(owner);
            _ctx.SaveChanges();
        }

        public void DeleteOwner(int selectedId)
        {
            _ctx.Owners.Remove(OwnerFoundById(selectedId));
            _ctx.SaveChanges();
        }

        public Owner OwnerFoundById(int selectedId)
        {
            return _ctx.Owners.FirstOrDefault(item => item.id == selectedId);
        }

        public IEnumerable<Owner> ReadOwners()
        {
            return _ctx.Owners;
        }

        public void UpdateOwner(int id, Owner newOwnerData)
        {
            _ctx.Owners.Update(newOwnerData);
            _ctx.SaveChanges();
        }
    }
}
