using TaskManager.Data.Repositories.Interfaces;
using TaskManager.Models;

namespace TaskManager.Data.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public void Add(ToDo toDo)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public ToDo Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(string id, ToDo updatedTodo)
        {
            throw new NotImplementedException();
        }
    }
}
