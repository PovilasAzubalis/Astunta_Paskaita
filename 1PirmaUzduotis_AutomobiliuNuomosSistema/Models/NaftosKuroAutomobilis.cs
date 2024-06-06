namespace PirmaUzduotis_AutomobiliuNuomosSistema.Models
{        // Toliau sukurti dvi subklases, NaftosKuroAutomobilis ir ElektrinisAutomobilis.
         // Kiekviena subklasė turi papildomą atributą, pavyzdžiui,
         // degalų suvartojimas 100 km atstumu arba baterijos krovimo laikas.
         // Taip pat, kiekviena subklasė turi turėti savo konstruktorių, kuris prideda šiuos papildomus atributus,
         // ir tinkamus getterius ir setterius.
        internal class NaftosKuroAutomobilis : Automobilis
        {
                float LitraiSimtuiKm;
                public NaftosKuroAutomobilis(int _id, string _marke, string _modelis, int _gamybosMetai, float nuomosKainaDienai, int dienuSkaicius, float litraiSimtuiKm) : base(_id, _marke, _modelis, _gamybosMetai, nuomosKainaDienai, dienuSkaicius)
                {
                        LitraiSimtuiKm = litraiSimtuiKm;
                }
                public NaftosKuroAutomobilis(int _id, string _marke, string _modelis, int _gamybosMetai, float nuomosKainaDienai, float litraiSimtuiKm) : base(_id, _marke, _modelis, _gamybosMetai, nuomosKainaDienai)
                {
                        LitraiSimtuiKm = litraiSimtuiKm;
                }

                public string ToString()
                {
                        return $"| {AutomobilioId} | {Marke} | {Modelis} | {Gamybosmetai} |{LitraiSimtuiKm}| {NuomosKaina} |";
                }
        }
}
