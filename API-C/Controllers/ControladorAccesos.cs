using DAL.Entidades;
using DAL;
using Microsoft.AspNetCore.Mvc;

namespace API_C.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControladorAccesos : ControllerBase
    {
        private readonly Contexto contexto;
        public ControladorAccesos(Contexto contexto)
        {
            this.contexto = contexto;
        }
        [HttpGet]
        public List<Acceso> GetUsuarios()
        {
            return contexto.accesos.ToList();
        }
        [HttpPost]
        public void PostUsuarios()
        {
            Acceso usu = new Acceso("31231231");
            contexto.accesos.Add(usu);
            contexto.SaveChanges();
        }
    }
}
