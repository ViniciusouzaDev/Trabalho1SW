using Microsoft.EntityFrameworkCore;
using Trabalho1SW.Models;

namespace Trabalho1SW.Context
{
    public class AppCont : DbContext
    {
        public AppCont(DbContextOptions<AppCont> options): base(options) 
        {
        
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
