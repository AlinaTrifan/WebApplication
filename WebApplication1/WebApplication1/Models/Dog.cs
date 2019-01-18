using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationHomeWork.Models
{
    public class Dog
    {
        public int Id { get; set; }
        [Required]
        public string DogName { get; set; }
        [Required]
        public Gender DogGender { get; set; }
        [Required]
        public FurColor DogFurColor { get; set; }
        [Required]
        [MinLength(5)]
        public string NickName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public Owner owner;
    }

    public class Owner
    {
        [Required]
        public string OwnerName { get; set; }
        [Required]
        [EmailAddress]
        public string OwnerEmail { get; set; }

        public Owner(string ownerName, string ownerEmail)
        {
            this.OwnerEmail = ownerEmail;
            this.OwnerName = ownerName;
        }
    }

    public enum Gender { Female, Male }

    public enum FurColor { Black, White, Yellow }
}