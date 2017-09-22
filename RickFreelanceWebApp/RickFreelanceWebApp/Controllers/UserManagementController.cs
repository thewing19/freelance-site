﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RickFreelanceWebApp.Data;
using RickFreelanceWebApp.Models;
using RickFreelanceWebApp.Models.UserManagementViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RickFreelanceWebApp.Controllers
{
    [Authorize]
    public class UserManagementController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly FreelanceContext _context;

        public UserManagementController(UserManager<ApplicationUser> userManager, FreelanceContext context)
        {
            _userManager = userManager;
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                Users = _userManager.Users
            };
            return View(model);
        }
    }
}