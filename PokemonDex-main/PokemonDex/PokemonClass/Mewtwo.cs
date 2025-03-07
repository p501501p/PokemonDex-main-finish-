using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex.PokemonClass
{
    internal class Mewtwo : Pokemon
    {
        public Mewtwo()
        {
        this.Name = "Mewtwo";
        this.Type = PokemonType.Psychic;
        this.Species = "Genetic Pokémon";
        this.Height = 2.0;
        this.Weight = 122.0;
        this.HP = 106;
        this.Attack = 110;
        this.Defense = 90;
        this.SpecialAttack = 154;
        this.SpecialDefense = 90;
        this.speed = 130;
        this.Total = 680;
            this.image = Resource1.ResourceManager.GetObject("mewtwo") as byte[] ?? Array.Empty<byte>();


        }
    }
}


