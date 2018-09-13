using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.DomainService
{
    public interface IPetShopRepository
    {
        IEnumerable<Pet> ReadPets();

        Pet PetFoundById(int selectedId);

        void CreatePet(Pet pet);

        void UpdatePet(int id, Pet newPetData);

        void DeletePet(int selectedId);
    }
}
