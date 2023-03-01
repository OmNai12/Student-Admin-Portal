using System;

namespace StudentAdminPortal.API.DataModels
{
    public class Student
    {
        // Guid is a 16-bytes (128 - bits long integer for unique id across all the computer in network.)
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        public Guid GenderId { get; set; }

        // Navigation Properties - Act as of forigen key.
        public Gender Gender { get; set; }
        public Address Address { get; set; }

    }
}
