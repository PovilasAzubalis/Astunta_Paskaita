using PirmaUzduotis_AutomobiliuNuomosSistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmaUzduotis_AutomobiliuNuomosSistema.Models
{
        internal class ElektrinisAutomobilis : Automobilis
        {
                int KrovimoLaikasMinutemis { get; set; }

                public ElektrinisAutomobilis(int _id, string _marke, string _modelis, int _gamybosMetai, float nuomosKainaDienai,int dienuSkaicius, int krovimoLaikasMinutemis) : base(_id, _marke, _modelis,_gamybosMetai, nuomosKainaDienai, dienuSkaicius)
                {
                        KrovimoLaikasMinutemis = krovimoLaikasMinutemis;
                }
                public ElektrinisAutomobilis(int _id, string _marke, string _modelis, int _gamybosMetai, float nuomosKainaDienai, int krovimoLaikasMinutemis) : base(_id, _marke, _modelis, _gamybosMetai, nuomosKainaDienai)
                {
                        KrovimoLaikasMinutemis = krovimoLaikasMinutemis;
                }

                public string ToString()
                {
                        return $"| {AutomobilioId} | {Marke} | {Modelis} | {Gamybosmetai} |{KrovimoLaikasMinutemis}| {NuomosKaina} |";
                }
        }
}
