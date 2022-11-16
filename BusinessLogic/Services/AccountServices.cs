﻿using BusinessLogic.DTO;
using BusinessLogic.Entites;
using BusinessLogic.Exceptions;
using BusinessLogic.Interfaice;
using BusinessLogic.Resourses;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountService(UserManager<User> userManager,
                              SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public async Task Register(RegisterDTO data)
        {
            var user = new User()
            {
                Email = data.Email,
                UserName = data.Username,
                PhoneNumber = data.PhoneNumber,
                TypeUsers = data.TypeUsers
            };

            var result = await userManager.CreateAsync(user, data.Password);

            if (!result.Succeeded)
            {
                string errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new HttpException(errors, HttpStatusCode.BadRequest);
            }
        }
        public async Task Login(string username, string password)
        {
            var user = await userManager.FindByNameAsync(username);

            if (user == null || !await userManager.CheckPasswordAsync(user, password))
            {
                throw new HttpException(ErrorMessages.InvalidCredentials, HttpStatusCode.BadRequest);
            }

            await signInManager.SignInAsync(user, true);
        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
        }
    }
}
