using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUD
{
    public class Enemy
    {
        //Variables

        public string name;
        public int maxHealth;
        public int currentHealth;
        public int damage;

        public Enemy(string name, int startHealth, int enemyDamage)
        {
            this.name = name;
            this.maxHealth = startHealth;
            this.currentHealth = maxHealth;
            this.damage = enemyDamage;
        }
    }
}
