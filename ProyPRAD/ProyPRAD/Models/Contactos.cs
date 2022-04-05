using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyPRAD.Models
{
    public class Contactos
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [MaxLength(70)]
        public String nombre { get; set; }

        [MaxLength(50)]
        public int telefono { get; set; }

        public String edad { get; set; }

        public String pais { get; set; }

        [MaxLength(100)]
        public String nota { get; set; }

        public Byte[] foto { get; set; }
    }
}
