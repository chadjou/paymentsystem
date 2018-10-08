using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TerminalServer.Models
{
    public class Terminal
    {
        [Key]
        int Id { get; set; }

        string Name { get; set; }

        string Address { get; set; }

        [ForeignKey("SellerId")]
        int SellerId { get; set; }
        public Seller Seller { get; set; }
    }
}
