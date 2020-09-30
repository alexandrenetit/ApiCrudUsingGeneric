using ApiCrudUsingGeneric.IService;
using ApiCrudUsingGeneric.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCrudUsingGeneric.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : GenericController<Teacher>
    {
        public TeachersController(IGenericService<Teacher> genericService) : base(genericService)
        {
        }
    }
}