using PirmaUzduotis_AutomobiliuNuomosSistema.Models;

namespace PirmaUzduotis_AutomobiliuNuomosSistema.Services
{
        // Sukurkite automobilių nuomos sistemą.

        // Jums reikės sukurti pagrindinę klasę Automobilis,
        // kuri turės šiuos atributus: marke, modelis, metai ir kaina už dieną.
        // Sukurkite reikiamus getterius ir setterius,
        // taip pat konstruktorių, leidžiantį sukurti automobilio objektą su nurodytais atributais.

        // Toliau sukurti dvi subklases, NaftosKuroAutomobilis ir ElektrinisAutomobilis.
        // Kiekviena subklasė turi papildomą atributą, pavyzdžiui,
        // degalų suvartojimas 100 km atstumu arba baterijos krovimo laikas.
        // Taip pat, kiekviena subklasė turi turėti savo konstruktorių, kuris prideda šiuos papildomus atributus,
        // ir tinkamus getterius ir setterius.

        // Galų gale, parašykite klasę Nuoma, kurioje yra sąrašas su turimais automobiliais.
        // Sukurti metodus, kurie leistų pridėti naujus automobilius į sąrašą,
        // pasiimti automobilį iš sąrašo ir apskaičiuoti nuomos kainą už nurodytą dienų skaičių.
        // Pridėti viso autoparko atspausdinimą. Susikūrus klasę autoparkas
        // prisidėti sąrašą automobilių.
        class UI
        {
                public static void Main(string[] args)
                {
                        Autoparkas autoparkas = new Autoparkas();
                        Nuoma nuoma = new Nuoma();

                        MenuText();
                        MenuInputCheck(out bool inputMenuCheck, out int inputMenu);

                        while (inputMenuCheck == true)
                        {

                                Menu(ref inputMenu, ref autoparkas, ref nuoma);
                                Console.WriteLine();
                                MenuText();
                                MenuInputCheck(out inputMenuCheck, out inputMenu);
                        }
                }

                public static (bool, int) MenuInputCheck(out bool inputMenuCheck, out int inputMenu)
                {
                        inputMenuCheck = int.TryParse(Console.ReadLine(), out inputMenu);
                        return (inputMenuCheck, inputMenu);
                }

                static void MenuText()
                {
                        Console.WriteLine("| MENU |");
                        Console.WriteLine("1 - Perziureti autoparko automobiliu sarasa.");
                        Console.WriteLine("2 - Prideti automobili i autoparko sarasa.");

                        Console.WriteLine("3 - Issinuomuoti automobili.");
                        Console.WriteLine("4 - Spausdinti isnuomuotu automobiliu sarasa");
                        Console.WriteLine("0 - Baigti darba.");
                }

                public static void Menu(ref int inputMeniu, ref Autoparkas autoparkas, ref Nuoma nuoma)
                {
                        switch (inputMeniu)
                        {
                                case 0:
                                        Environment.Exit(0);
                                        break;
                                case 1:
                                        autoparkas.SpausdintiAutoparkoSarasa();
                                        break;
                                case 2:
                                        int id = autoparkas.AutoparkoSarasas.Count > 0 ? autoparkas.AutoparkoSarasas.Max(X => X.AutomobilioId) + 1 : 0;
                                        autoparkas.PridetiIAutoparka(SukurkAutomobili(ref id));
                                        break;
                                case 3:
                                        nuoma.NuomuotiAutomobili(ref autoparkas);
                                        break;
                                case 4:
                                        nuoma.SpausdintiNuomosSarasa();
                                        break;
                                default:
                                        break;
                        }
                }

                public static Automobilis SukurkAutomobili(ref int id)
                {
                        Console.WriteLine("Kokio tipo automobili norite sukurti?");
                        Console.WriteLine("1 - Naftos kuro automobilis");
                        Console.WriteLine("2 - Elektrinis automobilis");

                        int automobilioTipas;

                automobilioTipoCheck:
                        try
                        {
                                automobilioTipas = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                                Console.WriteLine("iveskite 1 arba 2 ");
                                goto automobilioTipoCheck;
                        }

                        Console.Write("Iveskite automobilio marke: ");
                        string marke = Console.ReadLine();

                        Console.Write("Iveskite automobilio modeli: ");
                        string modelis = Console.ReadLine();

                        Console.Write("Iveskite automobilio gamybos metus: ");
                        int gamybosMetai;
                gamybosmetaiCheck:
                        try
                        {
                                gamybosMetai = int.Parse(Console.ReadLine());
                        }
                        catch (Exception blogaIvestis)
                        {
                                Console.WriteLine($"Error: {blogaIvestis.Message}\n Ivesties formatas: sveikieji skaiciai");
                                goto gamybosmetaiCheck;
                        }

                        Console.Write("Iveskite automobilio vienos dienos nuomos kaina: ");
                nuomosKainaDienaiCheck:
                        float nuomosKainaDienai;
                        try
                        {
                                nuomosKainaDienai = float.Parse(Console.ReadLine());
                        }
                        catch (Exception blogaIvestis)
                        {
                                Console.WriteLine($"Error: {blogaIvestis.Message}\n Ivesties formatas: 0.00");
                                goto nuomosKainaDienaiCheck;
                        }

                        switch (automobilioTipas)
                        {
                                case 1:
                                        Console.Write("Iveskite kuro sunaudojima (L / 100km): ");
                                        float litraiSimtuiKm;
                                LitraiSimtuiKmCheck:
                                        try
                                        {
                                                litraiSimtuiKm = float.Parse(Console.ReadLine());
                                        }
                                        catch (Exception e)
                                        {
                                                Console.WriteLine($"Error: {e.Message} Iveskite formatu 0.00");
                                                goto LitraiSimtuiKmCheck;
                                        }
                                        Automobilis automobilis = new NaftosKuroAutomobilis(id, marke, modelis, gamybosMetai, nuomosKainaDienai, litraiSimtuiKm);
                                        return automobilis;
                                case 2:
                                        Console.WriteLine("Iveskite krovimo laika minutemis: ");
                                        int krovimoLaikasMinutemis;
                                KrovimoLaikasCheck:
                                        try
                                        {
                                                krovimoLaikasMinutemis = int.Parse(Console.ReadLine());
                                        }
                                        catch (Exception e)
                                        {
                                                Console.WriteLine($"Error: {e.Message} Iveskite sveikuju skaiciu formatu");
                                                goto KrovimoLaikasCheck;
                                        }
                                        automobilis = new ElektrinisAutomobilis(id, marke, modelis, gamybosMetai, nuomosKainaDienai, krovimoLaikasMinutemis);
                                        return automobilis;
                                default: return null;


                        }

                }


        }
}
