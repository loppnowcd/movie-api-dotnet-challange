using Microsoft.EntityFrameworkCore;
using MovieApi.Api.Models;

namespace MovieApi.Api.Data;

// o MovieContext herda de DbContext, que é a classe principal do Entity Framework Core. ele é a "ponte" entre a minha aplicação e o banco de dados
public class MovieContext : DbContext
{
    // o construtor recebe as opcoes de configuracao do DbContext. isso permite que o Program.cs passe as informacoes necessarias para o contexto
    public MovieContext(DbContextOptions<MovieContext> options) : base(options)
    {
    }

    // a propriedade DbSet<Movie> representa a colecao de entidades. o Entity Framework Core vai usar isso para criar e interagir com uma tabela chamada "Movies" no banco de dados
    public DbSet<Movie> Movies { get; set; }
}