using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantMALO
{
    [Table("rezervare")]
    public class Rezervare
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public String Ora { get; set; }
        public String NrOaspeti { get; set; }
        public String Zona { get; set; }
        public String Nume { get; set; }
        public String Prenume { get; set; }
        public String Email { get; set; }
        public String Observatii { get; set; }

        public Rezervare()
        {

        }
    }
}
