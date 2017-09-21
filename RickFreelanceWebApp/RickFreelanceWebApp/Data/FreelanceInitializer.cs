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

            var contacts = new Contact[]
            {
                new Contact
                {
                    FirstName = "Rick",
                    LastName = "Volosky",
                    Email = "thewing19@yahoo.com",
                    Street = "420 West Center Street",
                    City = "Hastings",
                    State = "Michigan",
                    PostalCode = "49058"
                }
            };

            foreach (var contact in contacts)
            {
                context.Contacts.Add(contact);
            }

            context.SaveChanges();


        }
    }
}
