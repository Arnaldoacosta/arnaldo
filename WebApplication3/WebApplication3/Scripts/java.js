alert("hola");

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

//var foo = { foundation: "Mozilla", model: "box", week: 45, transport: "car", month: 7 };
var jsonString = JSON.stringify(motos, null, 4);


console.log('El json es: ' + this.jsonString);


//document.write(jsonString);



//for (x in jsonString) {

//console.log('que es x: ' + jsonString.marca[x+2]);
//$("#demo").text += myObj[X] + "<br>";

//el que funciona
document.getElementById("demo").innerHTML += jsonString + "<h1>";
//}


//$('#demo').append(jsonString);




//for(var i = 0; i < jsonString; i++)
//{
//    alert(i);
//    //Para obtener el objeto de tu lista
//    var obj = jsonString[i];
//    var lindo=(console.log(obj));
//    $('#demo').append(lindo + "</br> ");

//}

var objeto = JSON.parse(JSON.stringify(motos));
//$('#demo').append(objeto + "</br> ");





//Motos.push(honda);
//var myObj = { "name": "John", "age": 30, "car": null };
//    for (x in myObj) {

//        //$("#demo").text += myObj[X] + "<br>";

//        document.getElementById("demo").innerHTML += jsonString[x] + "<br>";
//    }




alert('dps for');
//document.getElementById("#texto").innerHTML += '<h1>' +'holaa' + "</h1>";


//$('#jsonStr').val(JSON.stringify(Motos));}

$.each(motos, function (i, f) {
    var tblRow = "<tr>" + "<td>" + f.marca + "</td>" +
        "<td>" + f.modelo + "</td>" + "</tr>"
    $(tblRow).appendTo("#userdata tbody");
});
