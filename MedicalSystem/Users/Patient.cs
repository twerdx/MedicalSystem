using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalSystem.Users
{
    public class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string BloodType { get; set; }

        public Patient(string name, string surname, string phoneNumber,  string email, string bloodType)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            BloodType = bloodType;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Patient Name: {Name} {Surname}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"");
        }
    }
}
