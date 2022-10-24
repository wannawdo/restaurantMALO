using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace restaurantMALO
{
    internal class ServiciuMeniu
    {
        public static async Task<List<Menu>> PreiaCurs()
        {
            List<Menu> listaMeniu = new List<Menu>();
            XmlReaderSettings settings = new XmlReaderSettings()
            {
                Async = true,
                DtdProcessing = DtdProcessing.Parse,
            };
            XmlReader reader = XmlReader.Create("https://github.com/microsoft/diner-wp/blob/master/wprestaurantapp_WP75/content/restaurant.xml", settings);
            DateTime data = DateTime.Now;
            while (await reader.ReadAsync())
            {
                if (reader.IsStartElement())
                {
                    Menu meniu = new Menu();

                    if (reader.Name == "category")
                    {
                        // initializare curs
                        meniu.Categorie = reader["name"];
                        
                        if(reader.Name == "dish")
                        {
                            meniu.Denumire = reader["name"];
                            meniu.Descriere = reader.Value;
                        }
                    }
                        await reader.ReadAsync();
                        listaMeniu.Add(meniu);
                        
                    }
                }
            
            return listaMeniu;
        }
    }
}
