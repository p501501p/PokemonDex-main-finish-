using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonDex
{


    public enum PokemonType
    {


        Electric,
        Hydro,
        Pyro,
        Cyro,
        Wind,
        Psychic,
        Normal,

    }

    public class Pokemon
    {   //class attributes
        public string Name;
        public int HP;
        public int Attack;
        public int Defense;
        public int SpecialAttack;
        public int SpecialDefense;
        public int speed;
        public int Total;
        public double Height;
        public double Weight;
        public string Species;
        public PokemonType Type;
        public byte[] image;
        // constuc

        public Pokemon()
        {

        }
        public void setName(string name)
        {
            Name = name;
        }

        public byte[] getImage()
        {
            return image;
        }
    }
}
