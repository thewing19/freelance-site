using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RickFreelanceWebApp.Models;

namespace RickFreelanceWebApp.Data
{
    public static class FreelanceInitializer
    {
        public static void Initialize(FreelanceContext context)
        {
            context.Database.EnsureCreated();

            //Look for any Contacts
            if (context.Contacts.Any())
            {
                return;
            }

            var addresses = new Address[]
            {
                new Address
                {
                    City = "Hastings",
                    State = "Michigan",
                    Street = "420 West Center Street",
                    PostalCode = "49058"
                }
            };

            foreach (var address in addresses)
            {
                context.Addresses.Add(address);
            }

            context.SaveChanges();

            var contacts = new Contact[]
            {
                new Contact {FirstName = "Rick", LastName = "Volosky", Email = "thewing19@yahoo.com", AddressID = 1}
            };

            foreach (var contact in contacts)
            {
                context.Contacts.Add(contact);
            }

            context.SaveChanges();

            
        }
    }
}
