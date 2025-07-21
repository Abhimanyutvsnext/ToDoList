using Microsoft.EntityFrameworkCore;
using toDoList.Models;

namespace toDoList.Data{
    public class AppDb : DbContext{
        public AppDb(DbContextOptions<AppDb> options) :base(options) {}
        public DbSet<List> Lists {get;set;}
    }
}
