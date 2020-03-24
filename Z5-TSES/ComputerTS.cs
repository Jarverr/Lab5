using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TSES
{
    [Table("Comp")]


    public class ComputerTS
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CoolingType { get; set; }
        public int Weight { get; set; }
        public int Id { get; set; }
        public virtual Server Server { get; set; }
    }

}
