using Microsoft.EntityFrameworkCore;

namespace dotnet.Models
{
public class Context : DbContext
{
public Context(DbContextOptions<Context> options)

: base(options)

{
}

public DbSet<Aluno> Aluno {get; set;}
public DbSet<Professor> Professor {get; set;}

}
}