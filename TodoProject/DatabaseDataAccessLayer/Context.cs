using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoProject.Models;

namespace TodoProject.DatabaseDataAccessLayer
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }

        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
