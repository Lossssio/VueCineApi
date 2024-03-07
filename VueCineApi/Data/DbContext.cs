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
// Configura la entidad Cine y sus relaciones.
modelBuilder.Entity<Cine>()
    .HasMany(c => c.Salas) // Un Cine tiene muchas Salas. Esto establece una relación uno a muchos.
    .WithOne(s => s.Cine) // Cada Sala está relacionada con un único Cine. Esto establece la relación inversa.
    .HasForeignKey(s => s.CineId); // Indica que la clave foránea en la entidad Sala es CineId.

// Configura la entidad Sala y sus relaciones.
modelBuilder.Entity<Sala>()
    .HasOne(s => s.Cine) // Cada Sala pertenece a un único Cine. Esto establece una relación muchos a uno.
    .WithMany(c => c.Salas) // Un Cine tiene muchas Salas. Esto establece la relación inversa.
    .HasForeignKey(s => s.CineId); // Indica que la clave foránea en la entidad Sala que apunta al Cine es CineId.

modelBuilder.Entity<Sala>()
    .HasMany(s => s.Sesiones) // Una Sala tiene muchas Sesiones. Esto establece una relación uno a muchos.
    .WithOne(se => se.Sala) // Cada Sesión se lleva a cabo en una única Sala. Esto establece la relación inversa.
    .HasForeignKey(se => se.SalaId); // Indica que la clave foránea en la entidad Sesión es SalaId.

modelBuilder.Entity<Sesion>()
    .HasOne(s => s.Movie) // Cada Sesión está asociada a una única Movie.
    .WithMany(m => m.Sesiones) // Una Movie puede estar asociada con muchas Sesiones.
    .HasForeignKey(s => s.MovieId); // La clave foránea en Sesión que apunta a la Movie es MovieId.


modelBuilder.Entity<Sesion>()
    .HasOne(s => s.Sala) // Cada Sesión se lleva a cabo en una única Sala. Esto establece una relación muchos a uno.
    .WithMany(s => s.Sesiones) // Una Sala puede contener muchas Sesiones. Esto establece la relación inversa.
    .HasForeignKey(s => s.SalaId); // Indica que la clave foránea en la entidad Sesión que apunta a la Sala es SalaId.

// Configura la entidad Asiento y sus relaciones.
modelBuilder.Entity<Asiento>()
    .HasOne(a => a.Sala) // Cada Asiento está asociado a una única Sala. Esto establece una relación muchos a uno.
    .WithMany(s => s.Asientos) // Una Sala tiene muchos Asientos. Esto establece la relación inversa.
    .HasForeignKey(a => a.SalaId); // Indica que la clave foránea en la entidad Asiento que apunta a la Sala es SalaId.

        
} 
//esta es la lista que contien todas las peliculas(se usa para CRUD)
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cine> Cines { get; set; }
    public DbSet<Sala> Salas { get; set; }
    public DbSet<Sesion> Sesiones { get; set; }
    public DbSet<Asiento> Asientos { get; set; }
     
}
}