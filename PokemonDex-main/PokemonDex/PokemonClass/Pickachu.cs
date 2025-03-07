﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace PokemonDex.PokemonClass
{
    public class Pickachu : Pokemon
    {
        public Pickachu()
        {
         this.Name = "Pickachu";
         this.Type = PokemonType.Electric;
         this.Species = "Mouse Pokémon";
         this.Height = 0.4;
         this.Weight = 6.0;
         this.HP = 35;
         this.Attack = 55;
         this.Defense = 40;
         this.SpecialAttack = 50;
         this.SpecialDefense = 50;
         this.speed = 90;
         this.Total = 320;
         this.image = Resource1.ResourceManager.GetObject("pikachu1") as byte[] ?? Array.Empty<byte>();

        }

    }
}
