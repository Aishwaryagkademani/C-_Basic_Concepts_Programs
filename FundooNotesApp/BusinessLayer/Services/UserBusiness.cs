using BusinessLayer.Interfaces;
using ModelLayer.Models;
using RepositoryLayer.Entity;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using RepositoryLayer.Interfaces;

namespace BusinessLayer.Services
{
    public class UserBusinesss : IUserBusiness
    {
        private readonly IUserRepo userRepo;
        public UserBusinesss(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }

        public UserEntity UserRegister(RegisterModel register)
        {
            return userRepo.UserRegister(register);
        }
    }
}
