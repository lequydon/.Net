using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.model
{
    class cntt
    {
        [Key]
        public string idsv { get; set; }
        public float pascal { get; set; }
        public float csap { get; set; }
        public float sql { get; set; }
    }
}
