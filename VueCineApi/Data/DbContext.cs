using VueCineApi.Models;
using Microsoft.EntityFrameworkCore;

namespace VueCineApi.Data
{
    public class ApplicationDbContext : DbContext //esto es que hereda de DbContext gracias al using Microsoft..
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
    {
    }

protected override void OnModelCreating (ModelBuilder modelBuilder)
{
    //llama al metodo
    base.OnModelCreating(modelBuilder);

    //modelbuilder permite modificar entidades como el nombre de la tabla, las claves primarias...
    modelBuilder.Entity<Movie>().HasData( //hasData es para poner datos iniciales al entidad
    
    new Movie
    {
        Id = 1,
        Image = "meg2.jpg",
        Title = "THE MEG 2",
        Director = "Jon turtle",
        Actors = "philipe marcus",
        Description = "es una película de acción y ciencia ficción dirigida por Jon Turteltaub y estrenada en 2018. La trama gira en torno a un grupo de científicos que deben detener a un megalodón"
    },
    new Movie
    {
        Id = 2,
        Image = "elhoyo.png",
        Title = "EL HOYO",
        Director = "Galder Gaztelu-Urrutia",
        Actors = "Martin Scorsese",
        Description = "es una película de ciencia ficción española dirigida por Galder Gaztelu-Urrutia, lanzada en 2019. La película se centra en un centro de reclusión vertical donde los prisioneros están dispuestos en celdas apiladas, y una plataforma de comida desciende a través de los niveles, dejando a los prisioneros de los niveles superiores con menos comida."
    },
    new Movie
    {
        Id = 3,
        Image = "mario.png",
        Title = "SUPER MARIO BROS",
        Director = "Martin Scorsese",
        Actors = "Leonardo DiCaprio",
        Description = "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino."
    },
    new Movie
    {
        Id = 4,
        Image = "granturismo.png",
        Title = "GRAN TURISMO",
        Director = "Quentin Tarantino",
        Actors = "Meryl Streep",
        Description = "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'."
    },
    new Movie
    {
        Id = 5,
        Image = "meg2.jpg",
        Title = "THE MEG 2",
        Director = "Alfred Hitchcock",
        Actors = "philipe marcus",
        Description = "es una película de acción y ciencia ficción dirigida por Jon Turteltaub y estrenada en 2018. La trama gira en torno a un grupo de científicos que deben detener a un megalodón"
    },
    new Movie
    {
        Id = 6,
        Image = "elhoyo.png",
        Title = "EL HOYO",
        Director = "Ben Wheatley",
        Actors = "Julia Roberts",
        Description = "es una película de ciencia ficción española dirigida por Galder Gaztelu-Urrutia, lanzada en 2019. La película se centra en un centro de reclusión vertical donde los prisioneros están dispuestos en celdas apiladas, y una plataforma de comida desciende a través de los niveles, dejando a los prisioneros de los niveles superiores con menos comida."
    },
    new Movie
    {
        Id = 7,
        Image = "mario.png",
        Title = "SUPER MARIO BROS",
        Director = "Alfred Hitchcock",
        Actors = "Leonardo DiCaprio",
        Description = "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino."
    },
    new Movie
    {
        Id = 8,
        Image = "granturismo.png",
        Title = "GRAN TURISMO",
        Director = "Quentin Tarantino",
        Actors = "Meryl Streep",
        Description = "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'."
    },
    new Movie
    {
        Id = 9,
        Image = "mario.png",
        Title = "SUPERMARIO BROS",
        Director = "Ben Wheatley",
        Actors = "Leonardo DiCaprio",
        Description = "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino."
    },
    new Movie
    {
        Id = 10,
        Image = "granturismo.png",
        Title = "GRAN TURISMO",
        Director = "Quentin Tarantino",
        Actors = "Meryl Streep",
        Description = "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'."
    }
);
} 
//esta es la lista que contien todas las peliculas(se usa para CRUD)
    public DbSet<Movie> Movies { get; set; }
}
}