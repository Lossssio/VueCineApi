<template>
        <div id="movieDetails" class="movieDetails">
        <!-- Contenedor para texto e imagen -->
        <div class="text-image-container">
            <!-- Aquí puedes mostrar la información de la película, incluida la imagen -->
            <div id="movieImage" class="image-container">
                <div class="gradient-overlay"></div>
                <img src="/imagenes/tu-imagen.jpg" class="image" alt="Nombre de la película">
            </div>
            <div class="text-container">
                <h1 id="movieTitle">Título de la Película</h1>
                <p id="movieDescription">Descripción de la película.</p>
                <!-- Otros detalles de la película... -->
            </div>
        </div>
        <button id="boton">Comprar</button>
    </div>
</template>