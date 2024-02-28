<template>
 <header>
            <nav class="header">
                <div class="left">
                    <img src="../assets/logosinletra.svg" class="logocine">
                </div>
                <ul class="right">
                    <a href="index.html"><li class="promo">Promos</li></a>
                    <a href="index.html"><li class="pelis">Películas</li></a>
                    <a href="index.html"><li class="billetes">Boletos</li></a>
                </ul>
            </nav>
        </header>
    
        <main class="principal">
            <div class="home">
                <div class="izquierda">
                    <img src="../assets/fotopalomitas.png">
                </div>
                <div class="derecha">
                <div class="textopresentacion">
                  <p class="f1">ZARAGOZA</p>
                  <p class="f2">CINES FLIX</p>
                  <p class="f3">Cines Flex, la mejor opción de disfrute audiovisual en toda la ciudad de Zaragoza. Ven a conocernos.</p>
                  <br>
                  <button class="botonhome">COMPRAR</button>
                </div>
                    
                    
                </div>
                </div>
            </main>
    
    
            <main class="cartelera">

                    <div id="movieInfo">
                    
                    </div>
                    
                   
                    
                    <div id="ticketForm">
                        <h1 class="titulocartelera">CARTELERA</h1>
                        <p class="subtitulo1cartelera">CINE PARA TODA LA FAMILIA</p>
                        <div class="linearoja"></div>
    
                      
                        <div class="peliculas" id="movieContainer">
                            <!-- Aquí se cargarán las imágenes de las películas -->
                        </div>
                
                        <!--<button onclick="buyTickets()">COMPRAR</button>-->
                    </div>
            <!--     
                    <div id="transactionHistory">
                        Aquí se mostrará el historial de transacciones 
                    </div> -->

                </main>
</template>

<style>
/* Estilos base */
body {
  padding: 0;
  margin: 0;
  background: linear-gradient(rgb(0, 0, 0), rgb(48, 48, 48));
  font-family: "Helvetica";
}

/* Header */
.header {
  background-color: rgb(196, 0, 0);
  height: 90px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.header .logocine {
  height: 60px;
}
.header .right {
  display: flex;
  justify-content: space-between;
  list-style: none;
  color: white;
  font-size: 20px;
}
.header .right .promo,
.header .right .pelis,
.header .right .billetes {
  margin-right: 30px;
  margin-left: 30px;
}

/* Página principal */
.principal {
  height: 100vh;
  height: calc(100vh - 90px);
  overflow-y: hidden;
  background: linear-gradient(to right, rgba(0, 0, 0, 0.5), transparent), url("assets/cinefondodegradado") center/cover no-repeat;
  background-position: right center;
}
.principal .home {
  background-repeat: no-repeat;
  background-size: 60vh;
  background-position: 300px;
  display: flex;
  justify-content: space-between;
  margin-top: 5%;
}
.principal .home .izquierda {
  margin-left: 12%;
}
.principal .home .derecha .textopresentacion {
  margin-left: 20%;
}
.principal .home .derecha .textopresentacion .f1 {
  color: white;
  font-family: "HelveticaCursiva";
  font-size: 100px;
  margin-bottom: -28px;
  margin-left: 1%;
}
.principal .home .derecha .textopresentacion .f2 {
  color: white;
  font-family: "HelveticaBold";
  font-size: 110px;
  margin: 0;
}
.principal .home .derecha .textopresentacion .f3 {
  color: white;
  font-family: "HelveticaThin";
  font-size: 28px;
  margin: 0;
  margin-left: 1%;
  width: 65%;
}
.principal .home .derecha .izquierda img {
  height: 600px;
}
.principal .home .derecha .botonhome {
  margin-left: 1%;
  margin-top: 3%;
  font-family: "HelveticaBold";
  display: inline-block;
  padding: 15px 30px;
  border-radius: 30px;
  background-color: red;
  color: black;
  text-decoration: none;
  border: none;
  cursor: pointer;
}

/* Cartelera */
.cartelera {
  display: flex;
  flex-wrap: wrap;
  justify-content: space-around;
  margin: 80px;
}
.cartelera .titulocartelera {
  font-size: 20px;
  margin-left: 10%;
  color: white;
  text-align: left;
}
.cartelera .subtitulo1cartelera {
  font-family: "HelveticaThin";
  margin-left: 10%;
  color: white;
  text-align: left;
  font-size: 250%;
  margin-bottom: 0%;
}
.cartelera .linearoja {
  margin-left: 10%;
  width: 80%;
  height: 6px;
  background-color: darkred;
}
.cartelera .peliculas img {
  width: 13%;
  margin: 30px;
  border-radius: 10px;
}
.cartelera #ticketForm {
  width: 100%;
  text-align: center;
}

/* Media query para dispositivos móviles */
@media only screen and (max-width: 767px) {
  body {
    text-align: center;
  }
  .left,
  .right {
    margin: 10px;
  }
  .header {
    flex-direction: column;
    align-items: center;
    height: auto;
  }
  .logocine {
    display: none;
  }
  .principal {
    height: 100vh;
    height: calc(100vh - 90px);
    overflow-y: hidden;
    background: linear-gradient(to right, rgba(0, 0, 0, 0.5), transparent), url("/assets/cinefondodegradado") center/cover no-repeat;
    background-position: right center;
  }
  .izquierda {
    display: none;
  }
  .right {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    list-style: none;
    color: white;
    font-size: 20px;
    margin-right: 8%;
    margin-top: 10px;
    text-align: center;
  }
  .right ul {
    padding: 0;
    margin: 0;
  }
  .right li {
    margin: 10px;
  }
  .textopresentacion {
    margin: 0;
    margin-top: 40%;
    text-align: center;
  }
  .f1 {
    font-size: 60px;
    margin-bottom: -23px;
    margin-left: 1%;
  }
  .f2 {
    font-size: 65px;
    margin: 0;
  }
  .f3 {
    font-size: 14px;
    margin: 0;
    margin-left: 1%;
    width: 90%;
  }
  .botonhome {
    margin: 10px 0;
    display: inline-block;
  }
  .home {
    background-position: center;
  }
  .izquierda img {
    width: 100%;
  }
  /*ESTILOS PARA CARTELERA*/
  .cartelera {
    margin: 0;
  }
  .cartelera .peliculas {
    margin: 0;
    display: flex;
    flex-wrap: wrap;
    justify-content: space-between;
    margin: 10px;
  }
  .cartelera .peliculas img {
    width: 30%;
    max-width: calc(48% - 10px);
    height: 100%;
    -o-object-fit: cover;
       object-fit: cover;
    margin-bottom: 10px;
  }
}/*# sourceMappingURL=index.css.map */
</style>

<script lang="ts">
import { defineComponent, ref, onMounted } from 'vue';

export default defineComponent({
  setup() {
    // Scroll down al hacer clic en el botón
    const botonHome = document.querySelector('.botonhome');
    const peliculasSection = document.querySelector('.peliculas');

    if (botonHome && peliculasSection) {
      botonHome.addEventListener('click', () => {
        peliculasSection.scrollIntoView({ behavior: 'smooth' });
      });
    }

    // Lógica para cargar películas
    const movieContainer = ref<HTMLElement | null>(null);

    onMounted(async () => {
      try {
        const response = await fetch('http://localhost:8001/api/movies');
        const data = await response.json();
        let moviesAdded = 0;

        data.forEach((movie: any, index: number) => {
          // Crear y agregar el subtítulo después de la primera fila de películas
          if (index === 5 && movieContainer.value) {
            const subtitulo = document.createElement('p');
            subtitulo.classList.add('subtitulo1cartelera');
            subtitulo.textContent = 'NUEVAS PELÍCULAS';
            movieContainer.value.appendChild(subtitulo);

            // Crear y agregar la línea roja después del subtítulo
            const linearoja = document.createElement('div');
            linearoja.classList.add('linearoja');
            movieContainer.value.appendChild(linearoja);
          }

          // Agregar la imagen
          const img = document.createElement('img');
          img.src = `/imagenes/${movie.image}`;
          img.alt = movie.title;
          img.setAttribute('data-movie-id', movie.id);
          img.addEventListener('click', () => redirectToinfoPeli(movie.id));

          // Agregar una clase a cada imagen para aplicar estilos específicos
          img.classList.add('movie-image', 'rounded-image'); // Agregar clase 'rounded-image'
          if (movieContainer.value) {
            movieContainer.value.appendChild(img);
          }

          // Incrementar la variable después de agregar la película
          moviesAdded++;
        });

      } catch (error) {
        console.error(error);
      }
    });

    function redirectToinfoPeli(movieId: string): void {
      window.location.href = `/infopeli.html?movieId=${movieId}`;
    }

    function redirectToVerificarButacas(movieId: string): void {
      // Puedes realizar algún trabajo adicional aquí si es necesario
      window.location.href = `/verificarButacas.html?movieId=${movieId}`;
    }

    return { movieContainer, redirectToinfoPeli, redirectToVerificarButacas };
  },
});
</script>

