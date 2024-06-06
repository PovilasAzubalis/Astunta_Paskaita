using PirmaUzduotis_AutomobiliuNuomosSistema.Models;

namespace PirmaUzduotis_AutomobiliuNuomosSistema.Services
{
        public class Autoparkas
        {
                public List<Automobilis> AutoparkoSarasas = new List<Automobilis>();

                public Autoparkas()
                {

                }
                public void PridetiIAutoparka(Automobilis automobilis)
                {
                        AutoparkoSarasas.Add(automobilis);
                }

                public void SpausdintiAutoparkoSarasa()
                {
                        Console.WriteLine("AUTOPARKAS SARASAS");
                        Console.WriteLine("Marke > Modelis > Gamybosmetai >  ( L/100km || Krovimo laikas) > NuomosKainaDienai");  
                        AutoparkoSarasas.OrderBy(x => x.AutomobilioId);
                        foreach (Automobilis a in AutoparkoSarasas.Where(x => x.NuomosStatusas == false))
                        {
                                if (a is ElektrinisAutomobilis)
                                {
                                        Console.WriteLine($"Elektromobilis {a.ToString()}");
                                }
                                else
                                {
                                        Console.WriteLine($"Naftos kuro automobilis {a.ToString()}");
                                }
                        }
                }
        }



}
