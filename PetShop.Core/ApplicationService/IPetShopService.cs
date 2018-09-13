using System.Collections.Generic;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationService
{
    public interface IPetShopService
    {
        List<Pet> GetPets();

        Pet PetFoundById(int selectedId);

        Pet PetFoundByIdPreviousOwnerIncluded(int selectedId);

        void CreatePet(Pet pet);

        List<Pet> Get5CheapestPets();

        List<Pet> GetPetsByPrice();

        List<Pet> GetPetsByType(string petType);

        void UpdatePet(int id, Pet pet);

        void DeletePet(int id);
    }
}
