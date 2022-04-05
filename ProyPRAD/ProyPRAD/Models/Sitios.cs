using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyPRAD.Models
{
    public class Sitios
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(50)]
        public String sitio { get; set; }

        public Byte[] foto { get; set; }

        public Double longitud { get; set; }
        public Double latitud { get; set; }

        public String pais { get; set; }

        [MaxLength(100)]
        public String nota { get; set; }

    }
}
