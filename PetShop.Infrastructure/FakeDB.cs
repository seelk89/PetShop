using PetShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetShop.Infrastructure
{
    public class FakeDB
    {
        public static IEnumerable<Pet> pets;
        public static IEnumerable<Owner> owners;

        //Init data
        #region
        public static void InitPetData()
        {
            var pet1 = new Pet()
            {
                id = 1,

                name = "Bob",

                type = "Dog",

                birthDate = DateTime.Now,

                soldDate = DateTime.Now,

                color = "black",

                previousOwner = owners.ToList().Single(item => item.id == 1),

                price = 10    
            };

            var pet2 = new Pet()
            {
                id = 2,

                name = "Cob",

                type = "Cat",

                birthDate = DateTime.Now,

                soldDate = DateTime.Now,

                color = "blue",

                previousOwner = owners.ToList().Single(item => item.id == 2),

                price = 100
            };

            var pet3 = new Pet()
            {
                id = 3,

                name = "Dob",

                type = "Mouse",

                birthDate = DateTime.Now,

                soldDate = DateTime.Now,

                color = "black",

                previousOwner = owners.ToList().Single(item => item.id == 3),

                price = 1000
            };

            pets = new List<Pet> { pet1, pet2, pet3 };
        }

        public static void InitOwnerData()
        {

            var owner1 = new Owner()
            {
                id = 1,

                firstName = "Bob",

                lastName = "Boob",

                address = "Street 1",

                phoneNumber = "123",

                email = "b@bmail"
            };

            var owner2 = new Owner()
            {
                id = 2,

                firstName = "Cob",

                lastName = "Coob",

                address = "Street 2",

                phoneNumber = "456",

                email = "c@cmail"
            };

            var owner3 = new Owner()
            {
                id = 3,

                firstName = "Dob",

                lastName = "Doob",

                address = "Street 3",

                phoneNumber = "789",

                email = "d@dmail"
            };

            owners = new List<Owner> { owner1, owner2, owner3 };
        }
        #endregion
    }
}
