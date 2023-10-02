using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicVilla_API.Modelos
{
    public class NumeroVilla //tiene una ralacion von la tabla Villa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)] //clave primaria que permite al usuario el dicha clave
        public int VillaNro { get; set; } //es el id de la tabla NumeroVilla

        public int VillaId { get; set; } //es el id de la tabla Villa

        [ForeignKey("VillaId")]
        public Villa villa { get; set; } //con esta linea indico que la propiedad de arriba es la clave foranea de la clase Villa
   
        public string DetalleEspecial { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaActualizacion { get; set; }
    }
}
