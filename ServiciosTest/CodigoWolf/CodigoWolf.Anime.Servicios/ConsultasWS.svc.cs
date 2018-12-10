using System;
using System.Collections.Generic;

namespace CodigoWolf.Anime.Servicios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ConsultasWS : IConsultaWS
    {
        public List<Anime> ListarAnimes()
        {
            List<Anime> animes = new List<Anime>();
            animes.Add(new Anime { Id = 1, Nombre = "Draogn Ball Z", Estado = true });
            animes.Add(new Anime { Id = 2, Nombre = "Naruto", Estado = true });
            animes.Add(new Anime { Id = 3, Nombre = "Yu Yu Hakusho", Estado = true });

            return animes;
        }
    }
}
