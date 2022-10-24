using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantMALO
{
    internal class DaoRezervare
    {
        SQLiteConnection conn;
        
        public DaoRezervare()
        {
            string caleDB = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "rezervari.db");
            conn = new SQLiteConnection(caleDB);
            conn.CreateTable<Rezervare>();
        }
        public int AdaugaRezervare(Rezervare rezervare)
        {
            return conn.Insert(rezervare);
        }
        public int AdaugaListaRezervare(List<Rezervare> listaRezervare)
        {
            return conn.InsertAll(listaRezervare);
        }

        public List<Rezervare> ObtineToateInregistrarile()
        {
            //return conn.Table<Curs>().ToList();
            return conn.Query<Rezervare>("SELECT * FROM Rezervare");
        }

        /*public List<Rezervare> ObtineCursDinData(DateTime data)
        {
            return conn.Query<Rezervare>("SELECT * FROM Curs WHERE date(Data) = ?", data.ToString("yyyy-MM-dd"));
        }*/
    }
}
