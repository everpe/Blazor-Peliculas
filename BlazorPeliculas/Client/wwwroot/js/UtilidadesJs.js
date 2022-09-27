//Invoca metodo C# desde funcion de JavaScript (Staticamente)
function pruebaPuntoNetStatic() {
    DotNet.invokeMethodAsync("BlazorPeliculas.Client", "ObtenerCurrentCount")
        .then(resultado => {
            console.log("Conteo Estático desde javascript " + resultado);
        });
}


//invoca metodo de Counter que incrementa el contador.
function pruebaPuntoNETInstancia(dotnetHelper) {
    dotnetHelper.invokeMethodAsync("IncrementCount");
}