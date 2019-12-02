using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.model
{
    class van
    {
        [Key]
        public string idsv { get; set; }
        public float vhcd { get; set; }
        public float vhhh { get; set; }
    }
}
