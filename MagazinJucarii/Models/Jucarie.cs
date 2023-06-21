using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinJucarii.Models
{
    public class Jucarie
    {
        [Key]
        public int CodJucarie { get; set; }
        public string? Denumire { get; set; }
        public int VarstaRecomandata { get; set; }
        public string? Serie { get; set; }
        public double? Pret { get; set; }
    }
}
