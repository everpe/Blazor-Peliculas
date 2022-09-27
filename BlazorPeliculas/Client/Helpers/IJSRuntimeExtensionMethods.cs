﻿using Microsoft.JSInterop;

namespace BlazorPeliculas.Client.Helpers
{
    public static class IJSRuntimeExtensionMethods
    {
        //Función confirmar de JavaScript
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string mensaje)
        {
            await js.InvokeVoidAsync("console.log", "prueba de console.log");
            return await js.InvokeAsync<bool>("confirm", mensaje);
        }
    }
}
