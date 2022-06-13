using MongoDB.Driver;
using TaskManager.Data.Configurations;
using TaskManager.Data.Repositories.Interfaces;
using TaskManager.Models;

namespace TaskManager.Data.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly IMongoCollection<ToDo> _todoCollection;

        public TodoRepository(IDatabaseConfig databaseConfig)
        {
            var client = new MongoClient(databaseConfig.DatabaseString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _todoCollection = database.GetCollection<ToDo>("todos");
        }

        public void Add(ToDo toDo)
        {
            _todoCollection.InsertOne(toDo);
        }

        public void Delete(string id)
        {
            _todoCollection.DeleteOne(todo => todo.Id == id);
        }

        public void Update(string id, ToDo updatedTodo)
        {
            _todoCollection
                .ReplaceOne(todo => todo.Id == id, updatedTodo);
        }

        public ToDo Get(string id)
        {
            return _todoCollection.Find(todo => todo.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<ToDo> GetAll()
        {
            return _todoCollection.Find(todo => true).ToList();
        }
    }
}
