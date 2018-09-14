//$(document).ready(function () {
    alert('hola');
    var motos = [];

//objeto Moto brava
var brava = new Object();
brava.marca = "brava altino";
    brava.modelo = [];
        //diferentes modelos
        var modelo1 = new Object();
        modelo1.nombre = "150";
        var modelo2 = new Object();
        modelo2.nombre = "200";

    brava.modelo.push(modelo1);
    brava.modelo.push(modelo2);
motos.push(brava);


//objeto Honda brava
var honda = new Object();
honda.marca = "honda titan";
honda.modelo = [];
    //diferentes modelos
    var modeloHonda = new Object();
    modeloHonda.nombre = "150rx";
    var modeloHonda2 = new Object();
    modeloHonda2.nombre = "200xx";

    honda.modelo.push(modeloHonda);
    honda.modelo.push(modeloHonda2);

motos.push(honda);


var jsonString = JSON.stringify(motos, null, 4);

document.getElementById("jsonStr").innerHTML += jsonString;



