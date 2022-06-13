namespace TaskManager.Models
{
    public class ToDo
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public bool Done { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime? DoneAt { get; private set; }

        public ToDo(string name, string description)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
            DoneAt = null;
            Done = false;
        }
    }
}
