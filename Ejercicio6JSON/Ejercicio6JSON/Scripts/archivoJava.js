
$(document).ready(function () {
    alert("hola");

    var json =
    {
        "moto":
            [
                {
                    "marca": "Brava",
                    "modelo":
                        [
                            { "nombre": "Aquila" },
                            { "nombre": "Altino" }
                        ]
                },
                {
                    "marca": "Honda",
                    "modelo":
                        [
                            { "nombre": "250" },
                            { "nombre": "150 Titan" }
                        ]

                },
                {
                    "marca": "rouser",
                    "modelo":
                        [
                            { "nombre": "150" },
                            { "nombre": "NS 200" }
                        ]

                }

            ]
    };

    var d= '<ul>'; 


    $('#btnMostar').click(function () {
        

        for (var i = 0; i < json.moto.length; i++)
        {
            
            d += '<li>' + json.moto[i].marca /*+ '</br>'*/;

            for (var j = 0; j < json.moto[i].modelo.length; j++)
            {
                
                d += '</br>'+'<ul><li>' + json.moto[i].modelo[j].nombre + '</li></ul>';
            }
            d += '</li>';
        }
        d += '</ul>';
        $("#demo").append(d);
    });




    //$(function () {
    //    for (var i = 0; i < json.moto.length; i++) {
    //        d += '<tr>' + '<td>' + json.moto[i].marca + '</td>';
    //        d += '<td>';
    //        for (var j = 0; j < json.moto[i].modelo.length; j++) {
    //            d += '<p>' + json.moto[i].modelo[j].nombre + '</p>';
    //        }
    //        d += '</td>';
    //        d += '</tr>';
    //    }
    //    $("#tabla").append(d);
    //});





    //var myObj = { "name": "John", "age": 30, "car": null };
    //for (x in myObj) {

    //    //$("#demo").text += myObj[X] + "<br>";

    //    document.getElementById("demo").innerHTML += myObj[x] + "<br>";
    //}








    //var myObj = {
    //    name: "Fer",
    //    edad: 30,
    //    autos: {
    //        "auto1": "fiat",
    //        "auto2": "Mercedes B."
    //    }
    //}



    //var objetos = {
    //    "personas": [
    //        { "nombre": "jorgue", "edad": 23 },
    //        { "nombre": "juan", "edad": 28 }
    //    ]
    //};

    
 

    //document.getElementById('demo').innerHTML = objetos.personas[1].nombre;

    //for (x in objetos) {
    //    document.getElementById("demo").innerHTML = objetos[x.nombre] + "<br>";

    //    document.getElementById("demo").innerHTML = objetos[x.edad] + "<br>";
    //}


    //for (x in myObj) {
    ////    document.getElementById("demo").innerHTML += myObj[x.name] + "<br>";
    //for (i in myObj) {
            
    //        document.getElementById("demo").innerHTML += myObj[i.autos.auto1] + "<br>";

    //    }
        
    ////}




    //var myObject = {
    //        sayHello: function () {
    //            console.log('Hola, mi nombre es ' + this.myName);
    //        },
    //        myName: 'Rebecca',
    //        edad:'2',
    //        sayage: function () {
    //            console.log('Hola, mi nombre es ' + this.edad);
    //        }
    //    };


 
    ////$("#mostrar").click(function () {
    ////    $("#titulo").show(1000);
    ////    $("#titulo1").show(1000);
    ////});
    ////$("#ocultar").click(function () {
    ////    $("#titulo").hide(1000);
    ////    $("#titulo1").hide(1000);
    ////});
    ////$("#btntogle").click(function () {
    ////    $("#titulotogle").toggle(1000);

    ////});

    ////$("#btntoglefade").click(function () {
    ////    $("#titulotoglefade").fadeToggle(1000);
    ////});
    ////$("#flip").click(function () {
    ////    $("#panel").slideDown("slow");
    ////});
    ////$("#btn1").click(function () {
    ////    var div = $("#caja1");
    ////    div.animate({ left: '100px' }, "slow");
    ////    div.animate({ fontSize: '3em' }, "slow");
    ////});
    

    ////$("#btnborrar").click(function () {
    ////    $("#caja22").remove();
    ////});

    
    ////$("#cambiartextocolor").click(function () {
    ////    $("#textocolor").addClass("estilocss");
    ////});


    ////$("#btncambiarajax").click(function () {
    ////    $("#textocambiar").load("help.html");
    ////});

  



    ////document.getElementById("demo").innerHTML += myObj.autos.auto1 + " ";
    ////document.getElementById("demo").innerHTML += myObj.autos.auto2;
  
    //////function superFuncion() {
    //////    document.getElementById("cambiajava").innerHTML="Oracle";
    //////}

    ////$('#btnMouse').click(function () {
    ////    $('#cambiajava').text("oracle cambie texto");
    ////    $('#cambiajava').css({"background-color": "yellow", "font-size": "100%" });
    ////})
    ////boton negrita
    //$('#btnnegrita').click(function () {
    ////    alert("hla");
    //    //$('#negritatexto').html("<b>aa</b>");

    //    //for (var i = 0; i < 5; i++) {
    //    //    $('#negritatexto').prepend("agrego texto:" + i + " ");
    //    //}

    //    ////probar condicion
    //    //var something = true;
    //    //for (var i = 0; i < 5; i++) {
    //    //    if (something) {
    //    //        alert("pasa");
    //    //        break;//corta el bucle
    //    //        // continue;//todo el codigo debajo de continue no se ejecutará y pasará a la siguiente iteraci´n
    //    //        alert("no pasa nada");
    //    //    }
    //    //    alert("pasa x afuera?");
    //    //    //else
    //    //    //{
    //    //    //    alert("muestra otro texto porque es falso");
    //    //    //    something = true;
    //    //    // }
    //    //    ////something = false;
    //    //    //// La siguiente declaración será ejecutada
    //    //    //// si la condición 'something' no se cumple
    //    //    //alert('continua');
    //    //}

    //    //var array = ['hola', 'hola2'];
    //    //array[1] = "piso";
    //    //array.push('pos3');
    //    //console.log(array);
    //    //console.log("despues de agregar");
    //    //console.log(array);

    //    //var array2 = ['nro:'];
    //    //for (var i = 0; i < 6; i++) {
    //    //    array2.push(i);
    //    //}
    //    //console.log("array 2");
    //    //console.log(array2);

    //    //var myArray = ['h', 'e', 'l', 'l', 'o'];
    //    //console.log(myArray);
    //    //var myString = myArray.join('');   // 'hello'
    //    //console.log(myString);
    //    //var mySplit = myString.split('');  // [ 'h', 'e', 'l', 'l', 'o' ]
    //    //console.log(mySplit);

    //    //$('#negritatexto').text(mySplit);

    //    //my code

    //    

    //    myObject.sayHello();    
    //    myObject.sayage();
    //    console.log('edad sola ' + myObject.edad);

    //    $('#negritatexto').text(myObject.edad);
        
    //});

    ////$('#btnvalor').click(function () {
    ////    $('#name').val("valor nuevo");
    ////})

    ////$('#textoentra').mouseenter(function () {
    ////    $('#textoentra').css({ "background-color": "yellow", "font-size": "200%" });
    ////    $('#textoentra').text("mouse entra");
    ////});

    ////$('#textoentra').mouseleave(function () {
    ////    $('#textoentra').css({ "background-color": "blue", "font-size": "200%" });
    ////    $('#textoentra').text("mouse se va");
    ////    $('#textoentra').css({ "color": "white" })
    ////});

    ////$('#myForm').submit(function () {
    ////    var data = formToObject(this);
    ////    alert(JSON.stringify(data));
    ////});

    ////function formToObject(form) {
    ////    var arrayForm = $(form).serializeArray();
    ////    var objectForm = {};

    ////    arrayForm.forEach(function (obj, index) {
    ////        objectForm[obj.name] = obj.value;
    ////    });

    ////    alert("hola en funcion");

    ////    return objectForm;
    ////}




    //$('#ejecutarAjax').click(function(){
    //    var ajaxRequest = new XMLHttpRequest();
    //    ajaxRequest.onreadystatechange = function () {
    //        if (ajaxRequest.readyState == 4 && ajaxRequest.status == 200) {
    //            $('#info').text = ajaxRequest.responseText;
    //        }
    //    }
    //    ajaxRequest.open("GET", "documento.txt", true);
    //    ajaxRequest.send();
    //});
  

    ////var myObj = { "name": "John", "age": 30, "car": null };

    ////for (x in myObj) {
    ////   $("#demo").text += myObj[x] + "<br>";
    ////}



});