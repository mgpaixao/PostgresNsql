using Microsoft.AspNetCore.Mvc;
using PostgresNsql.Models;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostgresNsql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly MyContext _myContext;
        public ValuesController(MyContext myContext)
        {
            _myContext = myContext;
        }
        [HttpGet]
        [Route("Getall")]
        public List<DataModel> GetAll()
        {
            return _myContext.DataModels.ToList();
        }
        // GET api/<ValuesController>/5
        [HttpGet]
        [Route("GetApenas1Propriedade")]
        public IEnumerable<string> Get()
        {
            var resultado = _myContext.DataModels;

            //return resultado.Where(x => x.idade == 12 && x.Data.RootElement.GetProperty("lastName").GetString() == "Paixao").ToList();
           
            return resultado.Select(x=>x.Data.RootElement.GetProperty("lastName").GetString()).ToList();
        }

        // POST api/<ValuesController>
        [HttpPost]  
        public void Post([FromBody] DataModel value)
        {
            _myContext.DataModels.Add(value);
            _myContext.SaveChanges();
            
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DataModel value)
        {
            _myContext.DataModels.Update(value);
            _myContext.SaveChanges();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var value = _myContext.DataModels.FirstOrDefault(x => x.Id == id);
            _myContext.DataModels.Remove(value);
            _myContext.SaveChanges();
        }
    }
}
