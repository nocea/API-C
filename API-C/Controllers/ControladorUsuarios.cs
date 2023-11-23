using DAL;
using DAL.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API_C.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //Controlador para la clase usuarios
    public class ControladorUsuarios : ControllerBase
    {   
        //Instancio el contexto
        private readonly Contexto contexto;
        public ControladorUsuarios (Contexto contexto)
        {
            this.contexto = contexto;
        }
        //Petición get para ver todos los usuarios
        [HttpGet]
        public List<Usuario> GetUsuarios()
        {
            return contexto.usuarios.ToList();
        }
        //Peticion post para añadir un nuevo usuario
        [HttpPost]
        public void PostUsuarios()
        {
            //Usuario de prueba del que solo se guarda el dni
            Usuario usu = new Usuario("31231231");//Lo añado
            contexto.usuarios.Add(usu);
            contexto.SaveChanges();//Guardo los cambios
        }
    }
}
