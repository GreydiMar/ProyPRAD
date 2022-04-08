using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProyPRAD.Models
{
    public class Contacts
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(20)]
        public string Nombres { get; set; }
        [MaxLength(20)]
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public DateTime Fechanac { get; set; }
        public string Parentesco { get; set; }
        public byte[] Foto { get; set; }

        [MaxLength(20)]
        public string Pais { get; set; }
    }
}
