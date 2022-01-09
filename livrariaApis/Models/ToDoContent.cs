using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace livrariaApis.Models
{
    public class ToDoContent : DbContext
    {

        public ToDoContent(DbContextOptions<ToDoContent> options) : base(options)
        {
        }
        public DbSet<Produto> todoProducts { get; set; }
    }
}
