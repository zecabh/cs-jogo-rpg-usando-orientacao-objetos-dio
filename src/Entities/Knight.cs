using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_jogo_de_rpg.src.Entities
{
    public class Knight : Hero
    {        
        public Knight(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        
        public override string Attack(){
            return this.Name + " attacked with sword!";
        }

        public override string Attack(int bonus){
             return this.Name + " attacked with sword with attack bonus of " + bonus + "!";
        }
    }
}