using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructure.SQLRepositories
{
    class PetShopRepository : IPetShopRepository
    {
        readonly PetShopContext _ctx;

        public PetShopRepository(PetShopContext ctx)
        {
            _ctx = ctx;
        }

        public void CreatePet(Pet pet)
        {
            _ctx.Add(pet);
            _ctx.SaveChanges();
        }

        public void DeletePet(int selectedId)
        {
            _ctx.Pets.Remove(PetFoundById(selectedId));
            _ctx.SaveChanges();
        }

        public Pet PetFoundById(int selectedId)
        {
            return _ctx.Pets.FirstOrDefault(item => item.id == selectedId);
        }

        public IEnumerable<Pet> ReadPets()
        {
            return _ctx.Pets;
        }

        public void UpdatePet(int id, Pet newPetData)
        {
            _ctx.Pets.Update(newPetData);
            _ctx.SaveChanges();
        }
    }
}
