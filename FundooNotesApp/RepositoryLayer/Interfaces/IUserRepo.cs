using System;
using System.Collections.Generic;
using System.Text;
using ModelLayer.Models;
using RepositoryLayer.Entity;
namespace RepositoryLayer.Interfaces
{
    public interface IUserRepo
    {
        public UserEntity UserRegister(RegisterModel register);
    }
}
