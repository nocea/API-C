﻿using DAL;
using DAL.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace API_C.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControladorUsuarios : ControllerBase
    {
        private readonly Contexto contexto;
        public ControladorUsuarios (Contexto contexto)
        {
            this.contexto = contexto;
        }
        [HttpGet]
        public List<Usuario> GetUsuarios()
        {
            return contexto.usuarios.ToList();
        }
        [HttpPost]
        public void PostUsuarios()
        {
            Usuario usu = new Usuario("31231231");
            contexto.usuarios.Add(usu);
            contexto.SaveChanges();
        }
    }
}
