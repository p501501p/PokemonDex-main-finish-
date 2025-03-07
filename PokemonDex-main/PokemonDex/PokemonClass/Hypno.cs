using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex.PokemonClass
{
    internal class Hypno :Pokemon
    {
        public Hypno() {
            this.Name = "Hypno";
            this.Type = PokemonType.Psychic;
            this.Species = "Hypnosis Pokémon";
            this.Height = 1.6;
            this.Weight = 75.6;
            this.HP = 85;
            this.Attack = 73;
            this.Defense = 70;
            this.SpecialAttack = 73;
            this.SpecialDefense = 115;
            this.speed = 67;
            this.Total = 483;
            this.image = Resource1.ResourceManager.GetObject("hypno") as byte[] ?? Array.Empty<byte>();
        }
    }
}
