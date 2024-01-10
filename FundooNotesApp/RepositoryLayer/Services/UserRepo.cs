using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer.Models;
using RepositoryLayer;
using RepositoryLayer.Interfaces;
namespace RepositoryLayer.Services
{
    public class UserRepo : IUserRepo
    {
        private readonly FundooContext fundooContext;
        public UserRepo(FundooContext fundooContext)
        {
            this.fundooContext = fundooContext;
        }

        public UserEntity UserRegister(RegisterModel register)
        {
            UserEntity entity = new UserEntity();
            entity.FirstName=register.FirstName;
            entity.LastName=register.LastName;
            entity.EmailId=register.EmailId;
            entity.Password=register.Password;
            fundooContext.Users.Add(entity);
            fundooContext.SaveChanges();
            return entity;
        }
    }
}
