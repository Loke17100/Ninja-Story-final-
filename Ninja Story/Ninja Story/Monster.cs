using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninja_Story
{
    class Monster
    {
        public int MonsterHealth { get; set; }
        public int PlayerBA { get; set; }
        public int PlayerSA { get; set; }

        public void MonsterSAttack()
        {
            Console.WriteLine("You hit the Enemy! with your special Attack!");
        }
        public void MonsterBAttack()
        {
            Console.WriteLine("You hit the Enemy! with your Weapon!");
        }
        public void PlayerBAttack()
        {
            Console.WriteLine("You hit the Enemy! with your Basic Attack! he loses 50 points of HP");
        }


    }
}
