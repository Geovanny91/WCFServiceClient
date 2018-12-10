using System;
using System.Collections;
using System.Linq;
using System.Web.Services;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]

    public static IList Listar()
    {
        var objeto = new AnimeConsultasWS.ConsultaWSClient().ListarAnimes();
        var items = (from x in objeto
                     select new
                     {
                         Id = x.Id,
                         Nombre = x.Nombre,
                         Estado = x.Estado,
                         Mensaje = "Mensaje de nada"
                     }
                     );
        return items.ToList();
    }

}