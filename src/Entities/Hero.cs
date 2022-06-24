using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_jogo_de_rpg.src.Entities
{
    public abstract class Hero
    {    
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }

        public Hero()
        {
        }

        public string Name { get; set; }

        public int Level { get; set; }

        public string HeroType { get; set; }

        public virtual string Attack(){
            return this.Name + " attacked!";
        }

        public virtual string Attack(int bonus){
            return this.Name + " attacked with bonus!";
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }
        
    }
}