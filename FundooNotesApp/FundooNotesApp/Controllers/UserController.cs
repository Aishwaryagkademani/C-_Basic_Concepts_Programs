using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Entity;
using System.Net.Http;
using BusinessLayer.Interfaces;
using ModelLayer.Models;
using BusinessLayer.Services;
namespace FundooNotesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBusiness userBusiness;
        public UserController(IUserBusiness userBusiness )
        {
            this.userBusiness = userBusiness;
        }

        [HttpPost]
        [Route("reg")]
        public IActionResult Register(RegisterModel model)
        {
            var result = userBusiness.UserRegister(model);
            if(result != null)
            {
                return Ok(new ResponseModel<UserEntity> { Success = true, Message = "Register SucessFull", Data = result });
            }
            else
            {
                return BadRequest(new ResponseModel<UserEntity> { Success = false, Message = "Register not successfull" });
            }
        }
    }
}
