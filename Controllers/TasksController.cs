using Microsoft.AspNetCore.Mvc;
using TaskManager.Data.Repositories.Interfaces;
using TaskManager.Models;

namespace TaskManager.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private ITodoRepository _todoRepository;

        public TasksController(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        // GET: api/<TasksController>
        [HttpGet]
        public IActionResult Get()
        {
            var todos = _todoRepository.GetAll();
            return Ok(todos);
        }

        // GET api/<TasksController>/{id}
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var todo = _todoRepository.Get(id);

            if (todo == null)
            {
                return NotFound("Todo not found");
            }

            return Ok(todo);
        }

        // POST api/<TasksController>
        [HttpPost]
        public IActionResult Post([FromBody] ToDo todo)
        {
            _todoRepository.Add(todo);
            return Ok("Todo added");
        }

        // PUT api/<TasksController>/5
        [HttpPut("{id}")]
        public IActionResult Put(string id, [FromBody] ToDo toDo)
        {
            _todoRepository.Update(id, toDo);
            return Ok("Todo updated");
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _todoRepository.Delete(id);
            return Ok("Todo deleted");
        }
    }
}
