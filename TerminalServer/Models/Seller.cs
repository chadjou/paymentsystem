using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalServer.Models
{
    public class Seller
    {
        [Key]
        int Id { get; set; }

        string Name { get; set; }

        string Address { get; set; }

        public List<Terminal> Terminals { get; set; }
    }
}
