using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cs_jogo_de_rpg.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
        }
        
        public override string Attack(){
            return this.Name + " cast magic!";
        }

        public override string Attack(int bonus){
            
            if (bonus > 6){
                return this.Name + " cast magic SUPER EFFECTIVE with attack bonus of " + bonus + "!";
            }
            else{
                return this.Name + " cast magic with attack bonus of " + bonus + "!";
            }            
        }        
    }
}