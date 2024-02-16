using Login.DataAccess.Irepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using Login.Models;

namespace Login.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUdRepository Iudrep;
        public UserController(IUdRepository _Udrep) 
        {
            this.Iudrep = _Udrep;
        }

        [Route("InsertUser")]
        [HttpPost]
        public async Task<IActionResult> InsertEmployees([FromBody] User user)
        {

            try
            {
                var cout = await Iudrep.InsertUser(user);
                return Ok(cout + "record Insert successfully...!");
            }
            catch (Exception ex)
            {
                return BadRequest("sorry for inconviniance ...!\nWe Will solve the as soon as possible\n" + ex.Message);
            }
        }
        [Route("GetemailandPassword")]
        [HttpGet]
            public async Task<IActionResult> GetemailandPassword(string email,string password)
            {

                try
                {
                    var cout = await Iudrep.GetemailandPassword(email,password);
                    return Ok(cout);
                }
                catch (Exception ex)
                {
                    return BadRequest("sorry for inconviniance ...!\nWe Will solve the as soon as possible\n" + ex.Message);
                }

            
            }
    }
}
