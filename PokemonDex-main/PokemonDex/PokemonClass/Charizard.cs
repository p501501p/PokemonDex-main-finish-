using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex.PokemonClass
{
    internal class Charizard : Pokemon
    {
        public Charizard()
        {
         this.Name = "Charizard";
         this.Type = PokemonType.Pyro;
         this.Species = "Flame Pokémon";
         this.Height = 1.7;
         this.Weight = 90.5;
         this.HP = 78;
         this.Attack = 84;
         this.Defense = 78;
         this.SpecialAttack = 109;
         this.SpecialDefense = 85;
         this.speed = 100;
         this.Total = 534;
         this.image = Resource1.ResourceManager.GetObject("charizard") as byte[] ?? Array.Empty<byte>();
        }
    }
}
