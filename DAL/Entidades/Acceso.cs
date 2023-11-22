using System.ComponentModel.DataAnnotations;

namespace DAL.Entidades
{
    public class Acceso
    {
        [Key]
        public int id_acceso { get; set; }
        public string codigo_acceso { get; set; }
        public string? descripcion_acceso { get; set; }
        public Acceso(string codigo_acceso)
        {
            
            this.codigo_acceso = codigo_acceso;
            
        }
        public Acceso() { }
    }
}
