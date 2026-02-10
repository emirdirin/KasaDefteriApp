using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Internal;

namespace KasaDefteriApp.Models
{
    public class Kasa
    {
        /// made public to be accessible from EF Core
        public int KasaID { get; set; }
        public string KasaName { get; set; }

        public System.DateTime CreationTime { get; set; }

        public ICollection<Islem> Islems { get; set; } = new List<Islem>();

    }
}
