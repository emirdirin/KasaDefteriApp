using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KasaDefteriApp.Enums; // USE ENUM


namespace KasaDefteriApp.Models
{
    public class Islem
    {
        public int IslemID { get; set; }
        public string IslemName{ get; set; } // *

        public IslemType IslemType { get; set; } // Giren or Cikan // *

        public decimal IslemAmount { get; set; } // *

        public System.DateTime IslemDate { get; set; } // *

        //FOREIGN KEY
        public int KasaID { get; set; }

        public Kasa Kasa { get; set; }
    }
}
