using PirmaUzduotis_AutomobiliuNuomosSistema.Models;

namespace PirmaUzduotis_AutomobiliuNuomosSistema.Services
{
        public class Nuoma
        {
                public List<Automobilis> automobiliuNuomosSarasas = new List<Automobilis>();
                public Nuoma()
                {

                }



                public void NuomuotiAutomobili(ref Autoparkas autoparkas)
                {
                        Console.Write("Iveskite nuomuojamo automobilio ID: ");
                        int id = 0;
                        try
                        {
                                int.TryParse(Console.ReadLine(), out id);
                        }
                        catch
                        {
                                Console.Write("Iveskite nuomuojamo automobilio ID: ");
                        }
                        Automobilis automobilis = autoparkas.AutoparkoSarasas.Find(x => x.AutomobilioId == id);
                        automobilis.NuomosStatusas = true;

                        Console.Write("Iveskite nuomuojamu dienu skaiciu: ");
                dienuSkaiciusCheck:
                        int dienuSkaicius;
                        try
                        {
                                dienuSkaicius = int.Parse(Console.ReadLine());
                        }
                        catch (Exception blogaIvestis)
                        {
                                Console.WriteLine($"Error: {blogaIvestis.Message}\n Ivesties formatas: sveikieji skaiciai");
                                goto dienuSkaiciusCheck;
                        }
                        automobilis.Kaina();
                        automobiliuNuomosSarasas.Add(automobilis);

                }
                public void SpausdintiNuomosSarasa()
                {
                        Console.WriteLine("NUOMOS SARASAS");
                        Console.WriteLine("Marke > Modelis > Gamybosmetai > ( L/100km || Krovimo laikas) > NuomosKaina");
                        try
                        {
                                foreach (ElektrinisAutomobilis a in automobiliuNuomosSarasas)
                                {
                                        Console.WriteLine($"{a} {a.NuomosKaina}|");
                                }
                        }
                        catch
                        {

                        }

                        try
                        {
                                foreach (NaftosKuroAutomobilis a in automobiliuNuomosSarasas)
                                {
                                        Console.WriteLine($"{a} {a.NuomosKaina}|");
                                }
                        }
                        catch
                        {
                               
                        }
                }



        }
}