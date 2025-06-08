using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDoAPI.Model.Entity;
using ToDoAPI.Model.Service;

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoRep _todoRep;

        public TodoController(TodoRep todoResp)
        {
            _todoRep = todoResp;
        }

        //get
        [HttpGet]

        public IActionResult Get()
        {
            var res = _todoRep.GetAll();
            return Ok(res);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public IActionResult Post([FromBody] Todo todo)
        {
             var res =  _todoRep.Add(todo);
            return Created("test.com",res);

        }

    

    }
}
