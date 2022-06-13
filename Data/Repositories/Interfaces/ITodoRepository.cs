using TaskManager.Models;

namespace TaskManager.Data.Repositories.Interfaces
{
    public interface ITodoRepository
    {
        void Add(ToDo toDo);

        void Update(string id, ToDo updatedTodo);

        IEnumerable<ToDo> GetAll();

        ToDo Get(string id);

        void Delete(string id);
    }
}
