using PirmaUzduotis_AutomobiliuNuomosSistema.Interfaces;
using PirmaUzduotis_AutomobiliuNuomosSistema.Services;

namespace PirmaUzduotis_AutomobiliuNuomosSistema.Models
{       // Jums reikės sukurti pagrindinę klasę Automobilis,
        // kuri turės šiuos atributus: marke, modelis, metai ir kaina už dieną.
        // Sukurkite reikiamus getterius ir setterius,
        // taip pat konstruktorių, leidžiantį sukurti automobilio objektą su nurodytais atributais.
        public class Automobilis: IAutomobilioSpausdinimas
        {
                public int AutomobilioId { get; set; }
                public string Marke { get; protected set; }
                public string Modelis { get; protected set; }
                public int Gamybosmetai { get; protected set; }
                public bool NuomosStatusas { get; set; }
                public float NuomosKainaDienai { get; protected set; }
                public int DienuSkaicius { get; protected set; }
                public float NuomosKaina { get; protected set; }
                public Automobilis()
                {
                        
                }
                public Automobilis(int automobilioId, string marke, string modelis, int gamybosmetai, float nuomosKainaDienai, int dienuSkaicius)
                {
                        AutomobilioId = automobilioId;
                        Marke = marke;
                        Modelis = modelis;
                        Gamybosmetai = gamybosmetai;
                        NuomosKaina = nuomosKainaDienai * dienuSkaicius;
                }
                public Automobilis(int automobilioId, string marke, string modelis, int gamybosmetai, float nuomosKainaDienai)
                {
                        AutomobilioId = automobilioId;
                        Marke = marke;
                        Modelis = modelis;
                        Gamybosmetai = gamybosmetai;
                        NuomosKainaDienai = nuomosKainaDienai;
                        NuomosKaina = nuomosKainaDienai;
                }

                public override string ToString()
                {
                        return $"| {AutomobilioId} | {Marke} | {Modelis} | {Gamybosmetai} | {NuomosKainaDienai} |";
                }
                
                public void Kaina()
                {
                        NuomosKaina = NuomosKainaDienai * DienuSkaicius;
                }
        }
}
