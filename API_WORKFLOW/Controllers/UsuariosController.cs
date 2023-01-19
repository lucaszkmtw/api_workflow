using API_WORKFLOW.DataAccess;
using API_WORKFLOW.DataAccess.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_WORKFLOW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
       

        

        public UsuariosController()
        {
           
        }

       [HttpGet(Name = "AddUsuario")]
       public Usuario AgregarUsuario()
        {

            DBaccess Agregado = new DBaccess();
            Agregado.Conexion();

            return Agregado.Conexion();
        }
    }
}