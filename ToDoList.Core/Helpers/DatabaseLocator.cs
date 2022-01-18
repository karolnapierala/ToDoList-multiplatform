using ToDoList.Database;

namespace ToDoList.Core
{
    public class DatabaseLocator
    {
        public static ToDoListDbContext DataBase { get; set; }
    }
}
