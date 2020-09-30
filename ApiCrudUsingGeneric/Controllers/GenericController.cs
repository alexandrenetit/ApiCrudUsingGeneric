using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCrudUsingGeneric.IService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCrudUsingGeneric.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : Controller where T : class
    {
        private readonly IGenericService<T> _genericService;

        public GenericController(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public List<T> Get()
        {
            return _genericService.GetAll();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public T Get(int id)
        {
            return _genericService.GetById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public List<T> Post([FromBody] T value)
        {
            return _genericService.Insert(value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public List<T> Delete(int id)
        {
            return _genericService.Delete(id);
        }
    }
}
