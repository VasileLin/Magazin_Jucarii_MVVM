using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinJucarii.Models
{
    public class Comanda
    {
        [Key]
        public int CodComanda { get; set; }
        public string? NumeClient { get; set; }
        public DateOnly DataProcurarii { get; set; }
        [ForeignKey("CodJucarie")]
        public int CodJucarie { get; set; }
        public virtual Jucarie? Jucarie { get; set; }
    }
}
