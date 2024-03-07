<template>
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
</template>

<script lang="ts">
export default {
    name: 'Principal'
}
</script>

<style scoped>
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
</style>
