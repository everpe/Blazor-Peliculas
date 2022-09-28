namespace BlazorPeliculas.Client.Helpers
{
    public class SelectorMultipleHelper
    {
        public SelectorMultipleHelper(string llave, string valor)
        {
            Llave = llave;
            Valor = valor;
        }

        public string Llave { get; set; }
        public string Valor { get; set; }
    }
}
