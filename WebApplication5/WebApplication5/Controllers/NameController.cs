using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Context;
using Database.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication5.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private readonly IJwtAuthenticationManager jwtAuthenticationManager;
        private readonly DatabaseContext DBContext;
        public NameController(IJwtAuthenticationManager jwtAuthenticationManager, DatabaseContext DBContext)
        {
            this.jwtAuthenticationManager = jwtAuthenticationManager;
            this.DBContext = DBContext;
        }

        // GET: api/<NameController>
        [HttpGet]
        public IEnumerable<Login> Get()
        {
            return DBContext.Login.ToList();
        }

        // GET api/<NameController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserCred userCred)
        {
            var token = jwtAuthenticationManager.Authenticate(userCred.Username, userCred.Password);
            if(token == null)
                return Unauthorized();
                return Ok(token);
            
        }
    }
}
