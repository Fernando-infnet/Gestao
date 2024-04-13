using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InfnetMVC.Models;

namespace InfnetMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Add a static Departamento during database initialization
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento
                {
                    DepartamentoId = 1,
                    Nome = "Departamento Estático",
                    Local = "Local Estático"
                },
                new Departamento
                {
                    DepartamentoId = 2,
                    Nome = "Departamento Estático B",
                    Local = "Local Estático B"
                }
            );

            // Add a static Funcionario during database initialization
            modelBuilder.Entity<Funcionario>().HasData(
                new Funcionario
                {
                    FuncionarioId = 1,
                    Nome = "José", // Example name
                    Endereco = "Endereço 1", // Example address
                    Telefone = "5555-5555", // Example phone number
                    Email = "jose@gmail.com", // Example email
                    DataNascimento = new DateTime(2004, 10, 10), // Example date of birth
                    DepartamentoId = 1 // Example department ID
                },
                new Funcionario
                {
                    FuncionarioId = 2,
                    Nome = "Fernando", // Example name
                    Endereco = "123 Main St", // Example address
                    Telefone = "6666-6666", // Example phone number
                    Email = "fernando@gmail.com", // Example email
                    DataNascimento = new DateTime(1998, 12, 12), // Example date of birth
                    DepartamentoId = 2 // Example department ID
                }
            );
        }
    }
}