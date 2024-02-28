using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueCineApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Director = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Actors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Actors", "Description", "Director", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "philipe marcus", "es una película de acción y ciencia ficción dirigida por Jon Turteltaub y estrenada en 2018. La trama gira en torno a un grupo de científicos que deben detener a un megalodón", "Jon turtle", "meg2.jpg", "THE MEG 2" },
                    { 2, "Martin Scorsese", "es una película de ciencia ficción española dirigida por Galder Gaztelu-Urrutia, lanzada en 2019. La película se centra en un centro de reclusión vertical donde los prisioneros están dispuestos en celdas apiladas, y una plataforma de comida desciende a través de los niveles, dejando a los prisioneros de los niveles superiores con menos comida.", "Galder Gaztelu-Urrutia", "elhoyo.png", "EL HOYO" },
                    { 3, "Leonardo DiCaprio", "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino.", "Martin Scorsese", "mario.png", "SUPER MARIO BROS" },
                    { 4, "Meryl Streep", "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'.", "Quentin Tarantino", "granturismo.png", "GRAN TURISMO" },
                    { 5, "philipe marcus", "es una película de acción y ciencia ficción dirigida por Jon Turteltaub y estrenada en 2018. La trama gira en torno a un grupo de científicos que deben detener a un megalodón", "Alfred Hitchcock", "meg2.jpg", "THE MEG 2" },
                    { 6, "Julia Roberts", "es una película de ciencia ficción española dirigida por Galder Gaztelu-Urrutia, lanzada en 2019. La película se centra en un centro de reclusión vertical donde los prisioneros están dispuestos en celdas apiladas, y una plataforma de comida desciende a través de los niveles, dejando a los prisioneros de los niveles superiores con menos comida.", "Ben Wheatley", "elhoyo.png", "EL HOYO" },
                    { 7, "Leonardo DiCaprio", "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino.", "Alfred Hitchcock", "mario.png", "SUPER MARIO BROS" },
                    { 8, "Meryl Streep", "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'.", "Quentin Tarantino", "granturismo.png", "GRAN TURISMO" },
                    { 9, "Leonardo DiCaprio", "En el colorido Reino Champiñón, Mario y Luigi disfrutan de una vida tranquila como fontaneros hasta que un día, Bowser, el rey de los Koopas, lanza un malévolo plan para robar todos los champiñones mágicos del reino.", "Ben Wheatley", "mario.png", "SUPERMARIO BROS" },
                    { 10, "Meryl Streep", "un talentoso piloto de carreras que, después de una serie de eventos inesperados, se encuentra en la oportunidad de su vida: competir en el torneo de carreras 'Gran Turismo'.", "Quentin Tarantino", "granturismo.png", "GRAN TURISMO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
