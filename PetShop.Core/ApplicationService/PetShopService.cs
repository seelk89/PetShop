using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PetShop.Core.DomainService;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationService
{
    public class PetShopService: IPetShopService
    {
        private readonly IPetShopRepository _petShopRepository;
        private readonly IOwnerRepository _ownerRepository;

        public PetShopService(IPetShopRepository petShopRepository, IOwnerRepository ownerRepository)
        {
            _petShopRepository = petShopRepository;
            _ownerRepository = ownerRepository;
        }

        public Pet PetFoundById(int selectedId)
        {
            return _petShopRepository.PetFoundById(selectedId);
        }

        public Pet PetFoundByIdPreviousOwnerIncluded(int selectedId)
        {
            var pet = _petShopRepository.PetFoundById(selectedId);
            pet.previousOwner = _ownerRepository.OwnerFoundById(pet.previousOwner.id);
            return pet;
        }

        public void CreatePet(Pet pet)
        {
            //Check of all of pet values
            if (string.IsNullOrEmpty(pet.name))
                throw new InvalidDataException("Pet needs a name");
            if (string.IsNullOrEmpty(pet.type))
                throw new InvalidDataException("Pet need to specify the type of pet the pet is");
            if (pet.birthDate == DateTime.MinValue)
                throw new InvalidDataException("Pet needs a birth date");
            if (pet.soldDate == DateTime.MinValue)
                throw new InvalidDataException("Pet needs a sold date");
            if (string.IsNullOrEmpty(pet.color))
                throw new InvalidDataException("Pet needs a color");
            if (pet.previousOwner == null || pet.previousOwner.id <= 0)
                throw new InvalidDataException("To create a pet you need a previous owner");
            if (_ownerRepository.OwnerFoundById(pet.previousOwner.id) == null)
                throw new InvalidDataException("Previous owner not found");
            if (pet.price == 0.0)
                throw new InvalidDataException("Pet needs a price");

            _petShopRepository.CreatePet(pet);
        }

        public List<Pet> GetPets()
        {
            return _petShopRepository.ReadPets().ToList();
        }

        public List<Pet> Get5CheapestPets()
        {
            return _petShopRepository.ReadPets().OrderBy(item => item.price).Take(5).ToList();
        }

        public List<Pet> GetPetsByPrice()
        {
            return _petShopRepository.ReadPets().OrderBy(item => item.price).ToList();
        }

        public List<Pet> GetPetsByType(string petType)
        {
            return _petShopRepository.ReadPets().Where(item => item.type.Equals(petType)).ToList();
        }

        public void UpdatePet(int id, Pet pet)
        {
            _petShopRepository.UpdatePet(id, pet);
        }

        public void DeletePet(int id)
        {
            _petShopRepository.DeletePet(id);
        }
    }
}
