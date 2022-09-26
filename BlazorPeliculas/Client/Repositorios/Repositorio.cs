using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula { Titulo = "<b>Mi Pelicula1</b>", Lanzamiento = DateTime.UtcNow },
                new Pelicula { Titulo = "<i>Mi Pelicula2</i>", Lanzamiento = DateTime.UtcNow },
                new Pelicula { Titulo = "Mi Pelicula3", Lanzamiento = DateTime.UtcNow }
            };
        }
    }
}
