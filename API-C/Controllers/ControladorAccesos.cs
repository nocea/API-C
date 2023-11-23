using DAL.Entidades;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace API_C.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //Controlador para la clase Accesos
    public class ControladorAccesos : ControllerBase
    {
        //Instancio el contexto
        private readonly Contexto contexto;
        public ControladorAccesos(Contexto contexto)
        {
            this.contexto = contexto;
        }
        //Petición para obtener todos los accesos
        [HttpGet]
        public List<Acceso> GetAccesos()
        {
            return contexto.accesos.ToList();
        }
        //Petición para añadir un nuevo acceso
        [HttpPost]
        public void PostAccesos()
        {   
            //Acceso de prueba
            Acceso usu = new Acceso("31231231");
            contexto.accesos.Add(usu);//Lo añado
            contexto.SaveChanges();//Guardo los cambios
        }
    }
}
