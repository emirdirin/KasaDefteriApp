using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasaDefteriApp.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciID { get; set; }

        public string KullaniciAdi { get; set; }

        public string SifreHash { get; set; }



    }
}
