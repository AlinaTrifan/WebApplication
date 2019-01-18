using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationHomeWork.Models;

namespace WebApplication1.Services
{
    public class DogRepository
    {
        private static List<Dog> dogs = new List<Dog>();
        private static DogRepository instance;

        public DogRepository()
        {

        }

        public static DogRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DogRepository();
                    dogs = InitializeList();
                }
                return instance;
            }
        }

            private static List<Dog> InitializeList()
        {
            List<Dog> dogs = new List<Dog>();
            dogs.Add(new Dog()
            {
                DogName = "Azorel",
                DogGender = Gender.Male,
                DogFurColor = FurColor.White,
                NickName = "Azo",
                DateOfBirth = DateTime.Now,
                //owner = new Owner("Alex", "alex@gmail.com")
                
            });
            dogs.Add(new Dog()
            {
                DogName = "Rex",
                DogGender = Gender.Male,
                DogFurColor = FurColor.Yellow,
                NickName = "Rexulet",
                DateOfBirth = new DateTime(2016, 11, 14)
            });
            dogs.Add(new Dog()
            {
                DogName = "Blanket",
                DogGender = Gender.Female,
                DogFurColor = FurColor.Black,
                NickName = "Paturica",
                DateOfBirth = new DateTime(2017, 01, 04)
            });
            return dogs;
        }
    
        public List<Dog> GetDogs()
        {
            return dogs;
        }

        public void AddDog(Dog dogToAdd)
        {
            dogs.Add(dogToAdd);
        }
    }
}
