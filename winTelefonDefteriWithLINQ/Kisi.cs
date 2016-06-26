using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winTelefonDefteriWithLINQ
{
    public class Kisi
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }
    }
}
