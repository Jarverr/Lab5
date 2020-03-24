using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z5_TSES
{
    [Table("Comp")]
    public class Server
    {
        public int ServerID { get; set; }
        public int ComputerId { get; set; }
        public int BandWidth { get; set; }
        public virtual ComputerTS Computer { get; set; }
    }
}
