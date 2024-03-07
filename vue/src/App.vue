<script setup lang="ts">
import Cartelera from './components/Cartelera.vue';
import Principal from './components/Principal.vue'
</script>

<template>

<header>
        <nav class="header">
                <div class="left">
                    <img src="./assets/logosinletra.svg" class="logocine">
                </div>
                <ul class="right">
                    <a href="index.html"><li class="promo">Promos</li></a>
                    <a href="index.html"><li class="pelis">Películas</li></a>
                    <a href="index.html"><li class="billetes">Boletos</li></a>
                </ul>
            </nav>
    </header>
  <main>
    <Principal/>
    <Cartelera/>

  </main>
</template>
<style>
body {
  padding: 0;
  margin: 0;
  background: linear-gradient(rgb(0, 0, 0), rgb(48, 48, 48));
  font-family: "Helvetica";
}
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
</style>

