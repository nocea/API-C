using System.ComponentModel.DataAnnotations;

namespace DAL.Entidades
{
    public class Acceso
    {
        [Key]
        public int id_acceso { get; set; }
        public string codigo_acceso { get; set; }
        public string descripcion_acceso { get; set; }
        public Acceso(int id_acceso, string codigo_acceso, string descripcion_acceso)
        {
            this.id_acceso = id_acceso;
            this.codigo_acceso = codigo_acceso;
            this.descripcion_acceso = descripcion_acceso;
        }
        public Acceso() { }
    }
}
