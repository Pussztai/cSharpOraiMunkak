using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LINQQ {
    class Pokemon {
        public int PokedexNumber { get; set; }

        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }

        public double WeightKg { get; set; }

        public int Generation { get; set; }

        public bool ISLegendary { get; set; }

        public Pokemon(string sor) {
            string[] adatok = sor.Split(',');
            PokedexNumber = Convert.ToInt32(adatok[0]);
            SpAttack = Convert.ToInt32(adatok[1]);
            SpDefense = Convert.ToInt32(adatok[2]);

            Speed = Convert.ToInt32(adatok[3]);
            Type1 = adatok[4];
            Type2 = adatok[5];
            if (adatok[6] == "") {
                WeightKg = 0.0;
            } else {
                WeightKg = Convert.ToDouble(adatok[6].Replace(".", ","));
            }

            Generation = Convert.ToInt32(adatok[7]);
            ISLegendary = adatok[8] == "1";



        }
    }

    class Pokemon2 {
        public List<string> Abilities { get; set; }
        public double Against_bug { get; set; }
        public double Against_dark { get; set; }
        public double Against_dragon { get; set; }
        public double Against_electric { get; set; }
        public double Against_fairy { get; set; }
        public double Against_fight { get; set; }
        public double Against_fire { get; set; }
        public double Against_flying { get; set; }
        public double Against_ghost { get; set; }
        public double Against_grass { get; set; }
        public double Against_ground { get; set; }
        public double Against_ice { get; set; }
        public double Against_normal { get; set; }
        public double Against_poison { get; set; }
        public double Against_psychic { get; set; }
        public double Against_rock { get; set; }
        public double Against_steel { get; set; }
        public double Against_water { get; set; }

        public int attack { get; set; }
        public int base_egg_steps { get; set; }
        public int base_happiness { get; set; }
        public int base_total { get; set; }
        public int capture_rate { get; set; }
        public string classfication { get; set; }
        public int defense { get; set; }
        public int experience_growth { get; set; }
        public double height_m { get; set; }
        public int hp { get; set; }
        public string name { get; set; }
        public double percentage_male { get; set; }
        public int pokedex_number { get; set; }

        public Pokemon2(string sor) {

            string pattern = @",(?=(?:[^\[\]]*\[[^\[\]]*\])*[^\[\]]*$)";
            string[] adatok = Regex.Split(sor, pattern);


            Abilities = adatok[0]
                .Replace("[", "")
                .Replace("]", "")
                .Replace("'", "")
                .Replace("\"", "")
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim())
                .ToList();


            double ParseDouble(string val) {
                val = val.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)
                         .Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                if (double.TryParse(val, NumberStyles.Any, CultureInfo.CurrentCulture, out double result))
                    return result;
                return 0.0;
            }


            Against_bug = ParseDouble(adatok[1]);
            Against_dark = ParseDouble(adatok[2]);
            Against_dragon = ParseDouble(adatok[3]);
            Against_electric = ParseDouble(adatok[4]);
            Against_fairy = ParseDouble(adatok[5]);
            Against_fight = ParseDouble(adatok[6]);
            Against_fire = ParseDouble(adatok[7]);
            Against_flying = ParseDouble(adatok[8]);
            Against_ghost = ParseDouble(adatok[9]);
            Against_grass = ParseDouble(adatok[10]);
            Against_ground = ParseDouble(adatok[11]);
            Against_ice = ParseDouble(adatok[12]);
            Against_normal = ParseDouble(adatok[13]);
            Against_poison = ParseDouble(adatok[14]);
            Against_psychic = ParseDouble(adatok[15]);
            Against_rock = ParseDouble(adatok[16]);
            Against_steel = ParseDouble(adatok[17]);
            Against_water = ParseDouble(adatok[18]);

            attack = Convert.ToInt32(adatok[19]);
            base_egg_steps = Convert.ToInt32(adatok[20]);
            base_happiness = Convert.ToInt32(adatok[21]);
            base_total = Convert.ToInt32(adatok[22]);


            capture_rate = adatok[23] == "" ? 0 : Convert.ToInt32(adatok[23]);

            classfication = adatok[24];
            defense = Convert.ToInt32(adatok[25]);
            experience_growth = Convert.ToInt32(adatok[26]);
            height_m = ParseDouble(adatok[27]);
            hp = Convert.ToInt32(adatok[28]);
            name = adatok[29];
            percentage_male = ParseDouble(adatok[30]);
            pokedex_number = Convert.ToInt32(adatok[31]);
        }
    }
    //pokedex_number, name, hp, generation,
    //type1, type2, classfication.
    public class MergedPokemon {
        public int PokedexNumber { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Speed { get; set; }
        public int Generation { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Classfication { get; set; }
    }



    internal class Program {

        static List<MergedPokemon> Osszefuzes(List<Pokemon> pokemonok,List<Pokemon2> pokemonok2) {
            var merged = (from p1 in pokemonok
                          join p2 in pokemonok2 on p1.PokedexNumber equals p2.pokedex_number
                          select new MergedPokemon {
                              PokedexNumber = p1.PokedexNumber,
                              Name = p2.name,
                              Hp = p2.hp,
                              Speed = p1.Speed,
                              Generation = p1.Generation,
                              Type1 = p1.Type1,
                              Type2 = p1.Type2,
                              Classfication = p2.classfication
                          }).ToList();

            return merged;
        }

        static MergedPokemon HighestHp(List<MergedPokemon> t) {
            return t.OrderByDescending(x=>x.Hp).First();
        }

        static List<MergedPokemon> PosionousPokemons(List<MergedPokemon> t) {
            return t.Where(x=>x.Type2 == "poison").ToList();
            
        }

        static MergedPokemon WeakestPoisonous(List<MergedPokemon> t) {
            return t.OrderBy(x => x.Hp).First();
        }

        //static void LessThan100(List<MergedPokemon> t) {

        //}

        static void Main(string[] args) {


            List<Pokemon> lista = Array.ConvertAll(File.ReadAllLines("../../inp.txt").ToList().Skip(1).ToArray(), row => new Pokemon(row)).ToList();
            List<Pokemon2> Lis = Array.ConvertAll(File.ReadAllLines("../../inp2.txt").ToList().Skip(1).ToArray(), row => new Pokemon2(row)).ToList();
            List<MergedPokemon> osszefuzott = Osszefuzes(lista, Lis);
            List<MergedPokemon> Poison = PosionousPokemons(osszefuzott);
            osszefuzott.Where(x => x.Speed > 100).Select(x => new { x.Name, x.Classfication, x.Speed }).OrderByDescending(x => x.Speed).ToList().ForEach(x => Console.WriteLine($"{x.Name}, {x.Classfication}, {x.Speed}"));
            Console.WriteLine(osszefuzott.GroupBy(x => x.Classfication).Count());
            Lis.Where(x => x.classfication == "Dragon Pokemon")
            .GroupBy(x => 1)
            .Select(g => new { AvgAttack = g.Average(x => x.attack), AvgDefense = g.Average(x => x.defense) });
           


        }
    }
}
