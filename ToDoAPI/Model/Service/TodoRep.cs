using ToDoAPI.Model.Data;
using ToDoAPI.Model.Entity;

namespace ToDoAPI.Model.Service
{
    public class TodoRep
    {

        private readonly ApplicationDbContext _context;

        public TodoRep(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Todo> GetAll()
        {
            var res = _context.Todos.ToList();
            return res;
        }

        public Todo Search(int id) 
        {
            var res = _context.Todos.SingleOrDefault(x => x.Id == id);
            return res;
           
        }
        public Todo Add(Todo todo) 
        {
            Todo item = new Todo()
            {
                Id = todo.Id,
                Title = todo.Title,
                IsDeleted = todo.IsDeleted,
                CreatedDate = DateTime.Now,
            };
            _context.Todos.Add(item);
            _context.SaveChanges();
            return todo;
        
        }

        public void Delete(Todo todo)
        { 
            _context.Todos.Remove(todo);
            _context.SaveChanges();
        
        }

        public bool Edit(Todo todo)
        {
            var res = _context.Todos.SingleOrDefault(p => p.Id == todo.Id);
            res.Title = todo.Title;
            return true;
        
        }




    }
}
