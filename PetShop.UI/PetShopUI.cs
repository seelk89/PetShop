using System;
using PetShop.Core.ApplicationService;
using PetShop.Core.Entity;

namespace PetShop.UI
{
    class PetShopUI
    {
        readonly IPetShopService _petShopService;

        public PetShopUI(IPetShopService petShopService)
        {
            _petShopService = petShopService;
        }

        public void StartUI()
        {
            while (true)
            {
                //Variables
                #region
                int selectedId;

                int birthYear;
                int birthMonth;
                int birthDay;
                int soldYear;
                int soldMonth;
                int soldDay;
                int previousOwnerId;
                double price;

                Pet pet = new Pet();
                Owner owner = new Owner();
                #endregion

                switch (ShowMenu())
                {
                    case 1:
                        //Creation of pet
                        #region
                        Console.Write("\n\tName of the pet: ");
                        pet.name = Console.ReadLine();
                        Console.Write("\n\tType of the pet: ");
                        pet.type = Console.ReadLine();

                        Console.Write("\n\tBirth year of the pet: ");
                        while (!int.TryParse(Console.ReadLine(), out birthYear) || birthYear < 2000 || birthYear > DateTime.Now.Year)
                        {
                            Console.WriteLine("\nSelect a number between 2000 and {0}: ", DateTime.Now.Year);
                        }

                        Console.Write("\n\tBirth month of the pet: ");
                        while (!int.TryParse(Console.ReadLine(), out birthMonth) || birthMonth < 1 || birthMonth > 12)
                        {
                            Console.WriteLine("\nSelect a number between 1 and 12");
                        }

                        Console.Write("\n\tBirth day of the pet: ");
                        while (!int.TryParse(Console.ReadLine(), out birthDay) || birthDay < 1 || birthDay > 31)
                        {
                            Console.WriteLine("\nSelect a number between 1 and 31: ");
                        }
                        pet.birthDate = new DateTime (birthYear, birthMonth, birthDay);

                        Console.Write("\n\tPet sold year: ");
                        while (!int.TryParse(Console.ReadLine(), out soldYear) || soldYear < 2000 || soldYear > DateTime.Now.Year)
                        {
                            Console.WriteLine("\nSelect a number between 2000 and {0}: ", DateTime.Now.Year);
                        }

                        Console.Write("\n\tPet sold month: ");
                        while (!int.TryParse(Console.ReadLine(), out soldMonth) || soldMonth < 1 || soldMonth > 12)
                        {
                            Console.WriteLine("\nSelect a number between 1 and 12");
                        }

                        Console.Write("\n\tPet sold day: ");
                        while (!int.TryParse(Console.ReadLine(), out soldDay) || soldDay < 1 || soldDay > 31)
                        {
                            Console.WriteLine("\nSelect a number between 1 and 31: ");
                        }
                        pet.soldDate = new DateTime(soldYear, soldMonth, soldDay);

                        Console.Write("\n\tColor of pet: ");
                        pet.color = Console.ReadLine();

                        Console.Write("\n\tId of previous owner between 1 and {0}: ", _petShopService.GetOwners().Count);
                        while (!int.TryParse(Console.ReadLine(), out previousOwnerId) || previousOwnerId < 1 || previousOwnerId > _petShopService.GetOwners().Count)
                        {
                            Console.WriteLine("\nSelect a number between 1 and {0}: ", _petShopService.GetOwners().Count);
                        }

                        Console.Write("\n\tPrice: ");
                        while (!double.TryParse(Console.ReadLine(), out price))
                        {
                            Console.WriteLine("\nSelect a number: ");
                        }
                        pet.price = price;

                        _petShopService.CreatePet(pet, previousOwnerId);

                        break;
                    #endregion
                    case 2:
                        //Reading of pets in DB
                        #region
                        foreach (var item in _petShopService.GetPets())
                        {
                            Console.Write("\n\tId: " + item.id);
                            Console.Write("\tName: " + item.name);
                            Console.Write("\tType: " + item.type);
                            Console.Write("\tBirthdate: " + item.birthDate);
                            Console.Write("\tSolddate: " + item.soldDate);
                            Console.Write("\tColor: " + item.color);
                            Console.Write("\tPrevious owner: " + item.previousOwner.id);
                            Console.Write("\tPrice: " + item.price);
                        }

                        Console.WriteLine("\n\nPress Enter to return to menu");
                        Console.ReadLine();

                        break;
                    #endregion
                    case 3:
                        //Search for pets by type
                        #region
                        Console.Write("\nWhat type of pet do you want to search for: ");
                        foreach (var item in _petShopService.GetPetsByType(Console.ReadLine()))
                        {
                            Console.Write("\n\tId: " + item.id);
                            Console.Write("\tName: " + item.name);
                            Console.Write("\tType: " + item.type);
                            Console.Write("\tBirthdate: " + item.birthDate);
                            Console.Write("\tSolddate: " + item.soldDate);
                            Console.Write("\tColor: " + item.color);
                            Console.Write("\tPrevious owner: " + item.color);
                            Console.Write("\tPrice: " + item.price);
                        }

                        Console.WriteLine("\n\nPress Enter to return to menu");
                        Console.ReadLine();

                        break;
                    #endregion
                    case 4:
                        //Get 5 cheapest pets
                        #region
                        foreach (var item in _petShopService.Get5CheapestPets())
                        {
                            Console.Write("\n\tId: " + item.id);
                            Console.Write("\tName: " + item.name);
                            Console.Write("\tType: " + item.type);
                            Console.Write("\tBirthdate: " + item.birthDate);
                            Console.Write("\tSolddate: " + item.soldDate);
                            Console.Write("\tColor: " + item.color);
                            Console.Write("\tPrevious owner: " + item.color);
                            Console.Write("\tPrice: " + item.price);
                        }

                        Console.WriteLine("\n\nPress Enter to return to menu");
                        Console.ReadLine();

                        break;
                    #endregion
                    case 5:
                        //Get pets by price
                        #region
                        foreach (var item in _petShopService.GetPetsByPrice())
                        {
                            Console.Write("\n\tId: " + item.id);
                            Console.Write("\tName: " + item.name);
                            Console.Write("\tType: " + item.type);
                            Console.Write("\tBirthdate: " + item.birthDate);
                            Console.Write("\tSolddate: " + item.soldDate);
                            Console.Write("\tColor: " + item.color);
                            Console.Write("\tPrevious owner: " + item.color);
                            Console.Write("\tPrice: " + item.price);
                        }

                        Console.WriteLine("\n\nPress Enter to return to menu");
                        Console.ReadLine();

                        break;
                    #endregion
                    case 6:
                        //Update pet
                        #region
                        Console.Write("\nSelect pet id between 1 and {0}, or type any ohter key to cancel: ", _petShopService.GetPets().Count);
                        if (int.TryParse(Console.ReadLine(), out selectedId) || selectedId < 0 || selectedId > _petShopService.GetPets().Count)
                        {
                            Console.Write("\n\tNew name of the pet: ");
                            pet.name = Console.ReadLine();
                            Console.Write("\n\tNew type of the pet: ");
                            pet.type = Console.ReadLine();

                            Console.Write("\n\tNew birth year of the pet: ");
                            
                            while (!int.TryParse(Console.ReadLine(), out birthYear) || birthYear < 2000 || birthYear > DateTime.Now.Year)
                            {
                                Console.WriteLine("\nSelect a number between 2000 and {0}: ", DateTime.Now.Year);
                            }

                            Console.Write("\n\tNew birth month of the pet: ");
                            
                            while (!int.TryParse(Console.ReadLine(), out birthMonth) || birthMonth < 1 || birthMonth > 12)
                            {
                                Console.WriteLine("\nSelect a number between 1 and 12");
                            }

                            Console.Write("\n\tNew birth date of the pet: ");
                            
                            while (!int.TryParse(Console.ReadLine(), out birthDay) || birthDay < 1 || birthDay > 31)
                            {
                                Console.WriteLine("\nSelect a number between 1 and 31: ");
                            }
                            pet.birthDate = new DateTime(birthYear, birthMonth, birthDay);

                            Console.Write("\n\tNew pet sold year: ");
                            
                            while (!int.TryParse(Console.ReadLine(), out soldYear) || soldYear < 2000 || soldYear > DateTime.Now.Year)
                            {
                                Console.WriteLine("\nSelect a number between 2000 and {0}: ", DateTime.Now.Year);
                            }

                            Console.Write("\n\tNew pet sold month: ");
                            
                            while (!int.TryParse(Console.ReadLine(), out soldMonth) || soldMonth < 1 || soldMonth > 12)
                            {
                                Console.WriteLine("\nSelect a number between 1 and 12");
                            }

                            Console.Write("\n\tNew pet sold date: ");
                            
                            while (!int.TryParse(Console.ReadLine(), out soldDay) || soldDay < 1 || soldDay > 31)
                            {
                                Console.WriteLine("\nSelect a number between 1 and 31: ");
                            }
                            pet.soldDate = new DateTime(soldYear, soldMonth, soldDay);

                            Console.Write("\n\tNew color of pet: ");
                            pet.color = Console.ReadLine();

                            Console.Write("\n\tNew id of previous owner between 1 and {0}: ", _petShopService.GetOwners().Count);
                            while (!int.TryParse(Console.ReadLine(), out previousOwnerId) || previousOwnerId < 1 || previousOwnerId > _petShopService.GetOwners().Count)
                            {
                                Console.WriteLine("\nSelect a number between 1 and {0}: ", _petShopService.GetOwners().Count);
                            }

                            Console.Write("\n\tNew price: ");
                            while (!double.TryParse(Console.ReadLine(), out price))
                            {
                                Console.WriteLine("\nSelect a number: ");
                            }
                            pet.price = price;

                            _petShopService.UpdatePet(selectedId, pet, previousOwnerId);
                        }
                        else
                        {
                            break;
                        }
                      
                        break;
                    #endregion
                    case 7:
                        //Deletion of pet
                        #region
                        Console.Write("\nSelect pet id between 1 and {0}, or type any ohter key to cancel: ", _petShopService.GetPets().Count);
                        if (int.TryParse(Console.ReadLine(), out selectedId) || selectedId < 0 || selectedId > _petShopService.GetPets().Count)
                        {
                            _petShopService.DeletePet(selectedId);
                        }
                        else
                        {
                            break;
                        }

                        break;
                    #endregion
                    case 8:
                        //Creation of owner
                        #region
                        Console.Write("\n\tOwners firstname: ");
                        owner.firstName = Console.ReadLine();
                        Console.Write("\n\tOwners lastname: ");
                        owner.lastName = Console.ReadLine();
                        Console.Write("\n\tOwners address: ");
                        owner.address = Console.ReadLine();
                        Console.Write("\n\tOwners phonenumber: ");
                        owner.phoneNumber = Console.ReadLine();
                        Console.Write("\n\tOwners email: ");
                        owner.email = Console.ReadLine();

                        _petShopService.CreateOwner(owner);

                        break;
                    #endregion
                    case 9:
                        //Reading of owners in DB
                        #region
                        foreach (var item in _petShopService.GetOwners())
                        {
                            Console.Write("\n\tId: " + item.id);
                            Console.Write("\tFirstname: " + item.firstName);
                            Console.Write("\tLastName: " + item.lastName);
                            Console.Write("\tAddress: " + item.address);
                            Console.Write("\tPhonenumber: " + item.phoneNumber);
                            Console.Write("\tEmail: " + item.email);
                        }

                        Console.WriteLine("\n\nPress Enter to return to menu");
                        Console.ReadLine();

                        break;
                    #endregion
                    case 10:
                        //Update owner
                        #region
                        Console.Write("\nSelect owner id between 1 and {0}, or type any ohter key to cancel: ", _petShopService.GetOwners().Count);
                        if (int.TryParse(Console.ReadLine(), out selectedId) || selectedId < 0 || selectedId > _petShopService.GetOwners().Count)
                        {
                            Console.Write("\n\tOwners new firstname: ");
                            owner.firstName = Console.ReadLine();
                            Console.Write("\n\tOwners new lastname: ");
                            owner.lastName = Console.ReadLine();
                            Console.Write("\n\tOwners new address: ");
                            owner.address = Console.ReadLine();
                            Console.Write("\n\tOwners new phonenumber: ");
                            owner.phoneNumber = Console.ReadLine();
                            Console.Write("\n\tOwners new email: ");
                            owner.email = Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }

                        _petShopService.UpdateOwner(selectedId, owner);

                        break;
                    #endregion
                    case 11:
                        //Deletion of owner
                        #region
                        Console.Write("\nSelect owner id between 1 and {0}, or type any ohter key to cancel: ", _petShopService.GetOwners().Count);
                        if (int.TryParse(Console.ReadLine(), out selectedId) || selectedId < 0 || selectedId > _petShopService.GetOwners().Count)
                        {
                            _petShopService.DeleteOwner(selectedId);
                        }
                        else
                        {
                            break;
                        }

                        break;
                    #endregion
                    case 12:
                        //Exit
                        Environment.Exit(0);

                        break;
                }
            }
        }

        //Selection menu
        #region
        private int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do?: ");

            Console.WriteLine("\n\t1: Create a pet");
            Console.WriteLine("\n\t2: Read available pets");
            Console.WriteLine("\n\t3: Search pets by type");
            Console.WriteLine("\n\t4: Get the 5 cheapest pets");
            Console.WriteLine("\n\t5: Get pets by price");
            Console.WriteLine("\n\t6: Update a pet");
            Console.WriteLine("\n\t7: Delete a pet");
            Console.WriteLine("\n\n\t8: Create a owner");
            Console.WriteLine("\n\t9: Read all owners");
            Console.WriteLine("\n\t10: Update a owner");
            Console.WriteLine("\n\t11: Delete a owner");
            Console.WriteLine("\n\n\t12: Exit\n");

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection < 1 || selection > 12)
            {
                Console.WriteLine("\nSelect a number between 1 and 12: ");
            }

            return selection;
        }
        #endregion
    }
}
