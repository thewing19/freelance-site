using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RickFreelanceWebApp.Models.UserManagementViewModels
{
    public class IndexViewModel
    {
        public IQueryable<ApplicationUser> Users { get; set; }
    }
}
