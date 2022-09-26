using static BlazorPeliculas.Client.Servicios;
using System;
using Microsoft.AspNetCore.Components;

namespace BlazorPeliculas.Client.Pages
{
    partial class Counter
    {
        //@inject
        [Inject] ServicioSingleton singleton { get; set; }
        [Inject] ServicioTransient transient { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            transient.Valor = currentCount;
            singleton.Valor = currentCount;
        }
    }
}
