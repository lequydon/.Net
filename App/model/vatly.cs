using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.model
{
    class vatly
    {
        [Key]
        public string idsv { get; set; }
        public float cohoc { get; set; }
        public float quanhoc { get; set; }
        public float dien { get; set; }
        public float vlhatnhan { get; set; }
    }
}
