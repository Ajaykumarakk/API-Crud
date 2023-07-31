using Microsoft.AspNetCore.Mvc;
using privateconsloe.Models;
using privateconsloe.Repository;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vegetable_register.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class Vegetable_reg : ControllerBase
    {
        VegetableRepository obj;  

        public Vegetable_reg()
        { 
            obj = new VegetableRepository();  
        }   
        // GET: api/<Vegetable_reg>
        [HttpGet]
        public IEnumerable<Vegetableinfo> Get()
        {
            return obj.select();  
        }

        // GET api/<Vegetable_reg>/5
        [HttpGet("{Sno}")]  
        public IEnumerable<Vegetableinfo> Get(int Sno)      
        {
            return obj.select(Sno);
        }

        // POST api/<Vegetable_reg>
        [HttpPost]
        public void Post([FromBody] Vegetableinfo value)
        {
            obj.insert(value);
        }



        // PUT api/<Vegetable_reg>/5
        [HttpPut("{Sno}")]
        public void Put(int Sno, [FromBody] Vegetableinfo value)
        {
            value.Sno = Sno;
            obj.Update(value);
        }                     

        // DELETE api/<Vegetable_reg>/5
        [HttpDelete("{Sno}")]
        public void Delete(int Sno)
        {
            obj.Delete(Sno);
        }
    }
}
