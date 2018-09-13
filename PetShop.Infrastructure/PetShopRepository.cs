using PetShop.Core.DomainService;
using PetShop.Core.Entity;
using PetShop.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace PetShop.Infrastructure
{
    public class PetShopRepository : IPetShopRepository
    {
        int petId = 4;

        public IEnumerable<Pet> ReadPets()
        {
            return FakeDB.pets;
        }

        public Pet PetFoundById(int selectedId)
        {
            var pet = FakeDB.pets.ToList().Single(item => item.id == selectedId);
            return pet;
        }

        public void CreatePet(Pet pet)
        {
            pet.id = petId;
            petId++;

            var _pets = FakeDB.pets.ToList();
            _pets.Add(pet);
            FakeDB.pets = _pets;
        }

        public void UpdatePet(int id, Pet newPetData)
        {
            var petToUpdate = this.PetFoundById(id);

            petToUpdate.name = newPetData.name;
            petToUpdate.type = newPetData.type;
            petToUpdate.birthDate = newPetData.birthDate;
            petToUpdate.soldDate = newPetData.soldDate;
            petToUpdate.color = newPetData.color;
            petToUpdate.previousOwner.id = newPetData.previousOwner.id;
            petToUpdate.price = newPetData.price;
        }

        public void DeletePet(int selectedId)
        {
            var _pets = FakeDB.pets.ToList();
            var pet = _pets.Single(item => item.id == selectedId);
            _pets.Remove(pet);
            FakeDB.pets = _pets;
        }
    }
}
