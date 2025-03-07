using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonDex.PokemonClass
{
    internal class Meowth:Pokemon
    {
        public Meowth()
        {
         this.Name = "Meowth";
         this.Type = PokemonType.Normal;
         this.Species = "Scratch Cat Pokémon";
         this.Height = 0.4;
         this.Weight = 4.2;
         this.HP = 40;
         this.Attack = 45;
         this.Defense = 35;
         this.SpecialAttack = 40;
         this.SpecialDefense = 40;
         this.speed = 90;
         this.Total = 290;
            this.image = Resource1.ResourceManager.GetObject("meowth") as byte[] ?? Array.Empty<byte>();
        }
    }
}
