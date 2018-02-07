using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUD
{
    public class Room
    {
        public Room(String name, String desc, int numberOfEnemies, Enemy baseEnemy)
        {
            this.desc = desc;
            this.name = name;
            enemiesInRoom = new Enemy[numberOfEnemies];
            if (baseEnemy != null)
            {
                for (int i = 0; i < numberOfEnemies; i++){enemiesInRoom[i] = new Enemy(baseEnemy.name + (i + 1), baseEnemy.maxHealth, baseEnemy.damage);}
            }
            
        }

        public String north
        {
            get { return exits[0]; }
            set { exits[0] = value; }
        }

        public String south
        {
            get { return exits[1]; }
            set { exits[1] = value; }
        }

        public String east
        {
            get { return exits[2]; }
            set { exits[2] = value; }
        }
        public String west
        {
            get { return exits[3]; }
            set { exits[3] = value; }
        }


        public String name = "";
        public String desc = "";
        public String[] exits = new String[4];
        public Enemy[] enemiesInRoom;
        public static String[] exitNames = { "NORTH", "SOUTH", "EAST", "WEST" };
    }

}
