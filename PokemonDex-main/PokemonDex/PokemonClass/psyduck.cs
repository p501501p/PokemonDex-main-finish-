using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex.PokemonClass
{
    internal class Psyduck:Pokemon
    { public Psyduck()
        {
       this.Name = "psyduck";
       this.Type = PokemonType.Hydro;
       this.Species = "Duck Pokémon";
       this.Height = 0.8;
       this.Weight = 19.6;
       this.HP = 50;
       this.Attack = 52;
       this.Defense = 48;
       this.SpecialAttack = 65;
       this.SpecialDefense = 50;
       this.speed = 55;
       this.Total = 320;
       this.image = Resource1.ResourceManager.GetObject("psyduck") as byte[] ?? Array.Empty<byte>();




        }
    }
}
