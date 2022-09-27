using static BlazorPeliculas.Client.Servicios;
using System;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using static BlazorPeliculas.Client.Shared.MainLayout;
using MathNet.Numerics.Statistics;

namespace BlazorPeliculas.Client.Pages
{
    partial class Counter
    {
        //@inject
        [Inject] ServicioSingleton singleton { get; set; }
        [Inject] ServicioTransient transient { get; set; }
        [Inject] protected IJSRuntime JS { get; set; }

        private int currentCount = 0;
        static int currentCountStatic = 0;

        //Permite importar modulos de JavaScript
        IJSObjectReference modulo;

        //Parametro heredado en toda la App
        [CascadingParameter] protected AppState appState { get; set; }



        //Se invoca desde JavaScript
        [JSInvokable]
        public async Task IncrementCount()
        {

            var arreglo = new double[] { 1, 2, 3, 4, 5 };
            var max = arreglo.Maximum();
            var min = arreglo.Minimum();

            modulo = await JS.InvokeAsync<IJSObjectReference>("import", "./js/Counter.js");
            await modulo.InvokeVoidAsync("mostrarAlerta", $"El max es {max} y el min es {min}");

            currentCount++;
            transient.Valor = currentCount;
            singleton.Valor = currentCount;
            currentCountStatic++;

            //Llama función Js que a su vez invoca elmetodo ObtenerCurrentCount de .Net. 
            await JS.InvokeVoidAsync("pruebaPuntoNetStatic");
        }


        //Se llama como Instancia desde JavaScript
        protected async Task IncrementCountJavacript()
        {
            await JS.InvokeVoidAsync("pruebaPuntoNETInstancia", DotNetObjectReference.Create(this));
        }

        //Se llama estaticamnete desde JavaScript
        [JSInvokable]
        public static Task<int> ObtenerCurrentCount()
        {
            return Task.FromResult(currentCountStatic);
        }
    }
}
