using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrilhaNetAzureDesafio.Models;

namespace TrilhaNetAzureDesafio.Context
{
    public class RHContext(DbContextOptions<RHContext> options) : DbContext(options)
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
