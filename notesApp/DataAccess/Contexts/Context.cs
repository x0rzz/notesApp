using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contexts
{
    public class Context : DbContext, IContext
    {
        public Context([NotNullAttribute] DbContextOptions options) 
            : base(options) { }
        public DbSet<UserRto> Users { get; set; }
        public DbSet<NoteRto> Notes { get; set; }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
