namespace ToDoAPI.Model.Entity
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Category> Categories { get; set; }

    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
