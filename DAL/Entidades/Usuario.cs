using System.ComponentModel.DataAnnotations;

namespace DAL.Entidades
{
    public class Usuario
    {
        [Key]
        public int id_usuario { get; set; }
        public string dni_usuario { set; get; }
        public string nombre_usuario { set; get; }
        public string apellidos_usuario { set; get; }
        public string tlf_usuario { set; get; }
        public string email_usuario { get; set; }
        public string clave_usuario { set; get; }
        public bool estaBloqueado_usuario { get; set; }
        public DateTime fch_fin_bloqueo_usuario { get; set; }
        public DateTime fch_alta_usuario { get; set; }
        public DateTime fch_baja_usuario { get; set; }
        
        //Constructores
        public Usuario(string dni_usuario)
        {
            this.dni_usuario = dni_usuario;
        }
        public Usuario() { }
    }
}
